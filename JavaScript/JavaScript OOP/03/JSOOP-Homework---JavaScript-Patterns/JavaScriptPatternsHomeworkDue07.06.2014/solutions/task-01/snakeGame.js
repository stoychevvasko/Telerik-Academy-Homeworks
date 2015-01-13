var snakeGame = (function () {
    var GAME_CANVAS = document.getElementById('snakeGame');
    var CURRENT_SCORE_ELEMENT = document.getElementById('score');
    var TOP_SCORES_ELEMENT = document.getElementById('top10');
    var BLOCK_SIZE = 10;
    var GAME_WIDTH = GAME_CANVAS.clientWidth;
    var GAME_HEIGHT = GAME_CANVAS.clientHeight;
    var CONTEXT = GAME_CANVAS.getContext('2d');
    var NUMBER_OF_APPLES = 3;
    var PLAYER_SCORE = 0;
    var TOP_SCORES_TO_DISPLAY = 10;
    var gameLoopControl;

    var startGame = function () {
        CONTEXT.clearRect(0, 0, GAME_WIDTH, GAME_HEIGHT);
        PLAYER_SCORE = 0;
        var playerSnake = new snake(6, 40, 20);
        var snakeBody = playerSnake.getsnakeBody();
        updateTopScores();
        keyboardControlsnake(playerSnake);
        var gameElements = [];
        gameElements['snake'] = playerSnake;
        gameElements['apples'] = [];
        for (var i = 0; i < NUMBER_OF_APPLES; i++) {
            gameElements['apples'].push(generateApple());
        }
        clearInterval(gameLoopControl);
        gameLoopControl = setInterval(function () {
            clearBoard();
            drawElements([playerSnake.head], '#66ccff');
            drawElements(snakeBody, '#a2e0ff');
            drawElements(gameElements['apples'], '#fff876');
            playerSnake.move();
            detectCollision(gameElements);
            PLAYER_SCORE++;
            updateScore();
        }, 100);
    }

    var endGame = function () {
        clearInterval(gameLoopControl);
        var playerName = prompt('Game over! Your score is ' + PLAYER_SCORE + '. Please enter your name:');
        if (playerName === null) {
            playerName = 'nameless';
        }
        localStorage.setItem(PLAYER_SCORE, playerName);
        updateTopScores();
    }

    var updateScore = function () {
        CURRENT_SCORE_ELEMENT.innerText = 'score: ' + PLAYER_SCORE;
    }

    var updateTopScores = function () {
        clearTopScores();
        var sortedScores = Object.keys(localStorage).sort(function (a, b) {
            return b - a;
        });

        for (var i = 0; i < TOP_SCORES_TO_DISPLAY; i++) {
            var currentScore = sortedScores[i];
            if (currentScore && currentScore !== undefined) {
                var scoreDiv = document.createElement('div');
                scoreDiv.innerText = localStorage[currentScore] + ' : ' + currentScore;
                TOP_SCORES_ELEMENT.appendChild(scoreDiv);
            }
        }
    }

    var clearTopScores = function () {
        while (TOP_SCORES_ELEMENT.firstChild) {
            TOP_SCORES_ELEMENT.removeChild(TOP_SCORES_ELEMENT.firstChild);
        }
    }

    var clearBoard = function () {
        CONTEXT.clearRect(0, 0, GAME_WIDTH, GAME_HEIGHT);
    }

    var generateApple = function () {
        var appleXPosition = Math.round((Math.random() * GAME_WIDTH - BLOCK_SIZE) / BLOCK_SIZE) * BLOCK_SIZE;
        var appleYPosition = Math.round((Math.random() * GAME_HEIGHT - BLOCK_SIZE) / BLOCK_SIZE) * BLOCK_SIZE;
        return new gameBlock(appleXPosition, appleYPosition);
    }

    var gameBlock = function (xPosition, yPosition) {
        if (xPosition % BLOCK_SIZE !== 0 || yPosition % BLOCK_SIZE !== 0) {
            throw new Error("The block coordinates must be within the canvas grid!");
        }

        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

    var snake = function (startLength, startX, startY) {
        this.head = new gameBlock(startX, startY);
        snakeBody = new Array(startLength - 1);
        for (var i = 0; i < startLength - 1; i++) {
            snakeBody[i] = new gameBlock(startX - BLOCK_SIZE * (i + 1), startY);
        }

        this.getsnakeBody = function () {
            return snakeBody;
        }

        this.direction = {
            x: 1,
            y: 0
        }

        this.move = function () {
            snakeBody.splice(snakeBody.length - 1, 1);
            snakeBody.unshift(new gameBlock(this.head.xPosition, this.head.yPosition));
            this.head.xPosition += this.direction.x * BLOCK_SIZE;
            this.head.yPosition += this.direction.y * BLOCK_SIZE;
        }
    }

    var drawElements = function (elements, color) {
        CONTEXT.fillStyle = color;
        for (var i = 0; i < elements.length; i++) {
            CONTEXT.fillRect(elements[i].xPosition, elements[i].yPosition, BLOCK_SIZE, BLOCK_SIZE);
        }
    }

    var detectCollision = function (gameElements) {
        var snakeHead = gameElements['snake'].head;
        var snakeBody = gameElements['snake'].getsnakeBody();
        var apples = gameElements['apples'];
        var hitVerticalWall = (snakeHead.xPosition < 0 || snakeHead.xPosition > GAME_WIDTH);
        var hitHorizontalWall = (snakeHead.yPosition < 0 || snakeHead.yPosition > GAME_HEIGHT);
        if (hitVerticalWall || hitHorizontalWall) {
            endGame();
            return;
        }

        for (var i = 0; i < snakeBody.length; i++) {
            if (snakeHead.xPosition === snakeBody[i].xPosition && snakeHead.yPosition === snakeBody[i].yPosition) {
                endGame();
                return;
            }
        }

        for (var i = 0; i < apples.length; i++) {
            if (apples[i].xPosition === snakeHead.xPosition && apples[i].yPosition === snakeHead.yPosition) {
                var newTailX = snakeBody[snakeBody.length - 1].xPosition * 2 - snakeBody[snakeBody.length - 2].xPosition;
                var newTailY = snakeBody[snakeBody.length - 1].yPosition * 2 - snakeBody[snakeBody.length - 2].yPosition;
                snakeBody.push(new gameBlock(newTailX, newTailY));
                apples.splice(i, 1);
                apples.push(generateApple());
                PLAYER_SCORE += 20;
            }
        }
    }

    var keyboardControlsnake = function (snake) {
        document.onkeydown = function (event) {
            event = event || window.event;
            switch (event.keyCode) {
                // left
                case 37:
                    if (snake.direction.x != 1 && snake.direction.y != 0) {
                        snake.direction.x = -1;
                        snake.direction.y = 0;
                    }
                    break;
                    // up
                case 38:
                    if (snake.direction.x != 0 && snake.direction.y != 1) {
                        snake.direction.x = 0;
                        snake.direction.y = -1;
                    }
                    break;
                    // right
                case 39:
                    if (snake.direction.x != -1 && snake.direction.y != 0) {
                        snake.direction.x = 1;
                        snake.direction.y = 0;
                    }
                    break;
                    // down
                case 40:
                    if (snake.direction.x != 0 && snake.direction.y != -1) {
                        snake.direction.x = 0;
                        snake.direction.y = 1;
                    }
                    break;
            }
        }
    }

    return {
        startGame: startGame,
        updateTopScores: updateTopScores
    }
})();