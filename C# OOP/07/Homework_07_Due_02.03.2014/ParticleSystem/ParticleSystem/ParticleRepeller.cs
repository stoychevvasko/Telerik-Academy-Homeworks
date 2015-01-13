namespace ParticleSystem
{
    public class ParticleRepeller
        : Particle
    {
        #region fields

        public static readonly char[,] ParticleRepellerImage =
        { 
            { ' ','↑',' ' }, 
            { '←','O','→' },
            { ' ','↓',' ' },
        };

        #endregion

        #region properties

        public int RepulsionPower { get; protected set; }

        #endregion

        #region constructor

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int pow) :
            base(position, speed)
        {
            this.RepulsionPower = pow;
        }

        #endregion

        #region method overrides

        public override char[,] GetImage()
        {
            return ParticleRepeller.ParticleRepellerImage;
        }

        #endregion
    }
}
