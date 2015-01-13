namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ChickenParticle
        : ChaoticParticle
    {
        #region fields

        public static readonly char[,] ChickenParticleImage = 
        { 
            { '^',' ',' ' }, 
            { '\\','/','/' },
            { ' ','m',' ' },
        };

        private static readonly MatrixCoords Stop = new MatrixCoords(0, 0);

        // 
        private const double ChanceToStop = 0.0001;

        #endregion

        #region constructors

        public ChickenParticle(MatrixCoords pos, MatrixCoords speed, Random rnd)
            : base(pos, speed, rnd)
        {
        }

        #endregion

        #region method overrides

        public override char[,] GetImage()
        {
            return ChickenParticle.ChickenParticleImage;
        }

        public override IEnumerable<Particle> Update()
        {
            if (this.Speed.Equals(ChickenParticle.Stop))
            {
                IEnumerable<Particle> baseParticles = base.Update();
                List<Particle> newChickens = new List<Particle>(baseParticles);
                newChickens.Add(new ChickenParticle(this.Position, ChickenParticle.Stop, this.random));
                return newChickens;
            }

            return base.Update();
        }

        protected override MatrixCoords GetRandomSpeed()
        {
            if (this.random.NextDouble() < ChickenParticle.ChanceToStop)
            {
                return ChickenParticle.Stop;
            }
            else
            {
                return base.GetRandomSpeed();
            }
        }

        #endregion
    }
}
