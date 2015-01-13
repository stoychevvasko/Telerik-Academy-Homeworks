(function () {    
        var stage = new Kinetic.Stage({
            container: 'container',
            width: 574,
            height: 250
        });

        var layer = new Kinetic.Layer();

        var imageObj = new Image();
        imageObj.onload = function () {
            var mario = new Kinetic.Sprite({
                x: 30,
                y: 157,
                image: imageObj,
                animation: 'idle',
                animations: {
                    idle: [
                    // x, y, width, height
                        80, 0, 40, 32,
                        40, 0, 40, 32,
                        0, 0, 40, 32,                        
                    ]
                },
                frameRate: 4,
                frameIndex: 0
            });
            
            layer.add(mario);            
            stage.add(layer);            
            mario.start();
        };

        imageObj.src = "../resources/imgs/mario.png";    
}());