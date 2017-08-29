using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace minions.Projectiles
{
    public class BananaPeelProj : ModProjectile
    {
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Banana Peel");
        } 
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.aiStyle = 1;
            projectile.tileCollide = true;
			projectile.timeLeft = 900;
            aiType = ProjectileID.WoodenArrowFriendly;
			projectile.friendly = true;
            projectile.scale = 1f;			
        }
		public override bool OnTileCollide(Vector2 oldVelocity)
        {
			{
			    projectile.active = true;
		    }
			return false;
        }
        public override void AI()
        {
            Player player = Main.player[Main.myPlayer];

			Lighting.AddLight(projectile.position, 0.34f, 0.34f, 0f);			
			
			projectile.velocity.X = 0f;
			
				if (projectile.timeLeft == 899 && player == Main.player[projectile.owner])
				{
					projectile.velocity.Y = 1;
				}
		}
    }
}