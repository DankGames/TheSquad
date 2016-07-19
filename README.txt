Basic Attack script needs to be attached on enemy.
Target field needs to be filled with Player prefab. (Or any object with PlayerHealth script attached on it)

Health Bar field needs to be filled with slider that represents health bar. Script will do everything for you.

HOW IT WORKS:

When you're in enemy's range, enemy will face you and start running towards you until you are in range, the enemy will stop and start playing animation and attacking you, when you die (isDead) enemy will stop. (This will be changed when we implement multyplayer so enemy will change target if there is anyone alive)

Enemy will shoot projectiles.

Attach EnemyProjectile script to sphere and adjust settings. This is temporary I believe.

Attach that sphere on BasicAttack script field where it says.

I've done some tweaks on how Enemy AI works, so update it as well.

That should be all.

Ask me if anything goes wrong.

~Veljko Lukic