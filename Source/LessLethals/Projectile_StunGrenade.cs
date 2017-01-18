using Verse;
using RimWorld;

namespace LessLethals
{
    public class Projectile_StunGrenade : Projectile_Explosive
    {
        protected override void Explode()
        {
            var map = Map; // before Destroy()!

            base.Explode();

            //Adds a bright flash to the stun grenade explosion
            MoteMaker.ThrowLightningGlow(base.Position.ToVector3Shifted(), map, 10F);
        }
    }
}
