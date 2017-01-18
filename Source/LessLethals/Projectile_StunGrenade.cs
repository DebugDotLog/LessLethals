using Verse;
using RimWorld;
using UnityEngine;

namespace LessLethals
{
    public class Projectile_StunGrenade : Projectile_Explosive
    {
        protected override void Explode()
        {
            LL_ThingDef mote_stunGrenade = LL_ThingDefOf.Mote_StunGrenade as LL_ThingDef;

            var map = Map; // before Destroy()!
            Vector3 position = ExactPosition;

            base.Explode();

            //Adds a bright flash to the stun grenade explosion
            MoteMaker.MakeStaticMote(position, map, mote_stunGrenade, mote_stunGrenade.scale);
        }
    }
}
