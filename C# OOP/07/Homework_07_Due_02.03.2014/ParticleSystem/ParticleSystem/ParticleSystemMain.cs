using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        static readonly Random randomGenerator = new Random();

        static void Main()
        {
            var renderer = new ConsoleRenderer(49, 79);
            
            //var particleOperator = new AdvancedParticleOperator();
            var particleOperator = new AdvancedParticleOperatorWithRepulsion();

            var particles = new List<Particle>()
            {
                // please uncomment *one section at a time* to test the new particle types
                
                // <problem 02> 
                
                //new ChaoticParticle(new MatrixCoords(25, 45), new MatrixCoords(0,0), randomGenerator),
                //new ChaoticParticle(new MatrixCoords(25, 45), new MatrixCoords(0,0), randomGenerator),
                //new ChaoticParticle(new MatrixCoords(25, 45), new MatrixCoords(0,0), randomGenerator),
                                
                // <Problem 04> 

                //new ChickenParticle(new MatrixCoords(30,40), new MatrixCoords(0,0),randomGenerator),
                
                // <Problem 06> 

                //new ParticleRepeller(new MatrixCoords(11,40), new MatrixCoords(0,0),1),
                //new ParticleRepeller(new MatrixCoords(17,40), new MatrixCoords(0,0),1),
                //new Particle(new MatrixCoords(13, 40), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(9, 40), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(11, 37), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(11, 43), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(14, 37), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(14, 43), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(17, 37), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(17, 43), new MatrixCoords(1, 1)),
                //new Particle(new MatrixCoords(19, 40), new MatrixCoords(1, 1)),                

            };

            Engine particleEngine = new Engine(renderer, particleOperator, particles, 500);
            particleEngine.Run();
        }
    }
}