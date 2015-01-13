// <Problem 01>

namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;    

    public class ChaoticParticle
        : Particle
    {
        #region fields

        public static readonly char[,] ChaoticParticleImage = 
        { 
            { ' ','│',' ' }, 
            { '─','┼','─' },
            { ' ','│',' ' },
        };
        protected Random random;

        // will be used to calculate limited random speed changes in GetRandomSpeed()
        private const int maxSpeedDeviation = 3;

        #endregion

        #region properties



        #endregion

        #region constructors

        public ChaoticParticle(MatrixCoords pos, MatrixCoords speed, Random rnd)
            : base(pos, speed)
        {
            this.random = rnd;
        }

        #endregion

        #region method overrides

        public override IEnumerable<Particle> Update()
        {
            this.Speed = GetRandomSpeed();
            return base.Update();
        }

        public override char[,] GetImage()
        {
            return ChaoticParticle.ChaoticParticleImage;
        }

        protected virtual MatrixCoords GetRandomSpeed()
        {
            return new MatrixCoords(
                                   this.random.Next(-maxSpeedDeviation, maxSpeedDeviation + 1),
                                   this.random.Next(-maxSpeedDeviation, maxSpeedDeviation + 1)
                                   );
        }

        #endregion
    }
}
