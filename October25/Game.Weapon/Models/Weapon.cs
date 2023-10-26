using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Weapon.Models
{
    public class Weapon
    {

        public readonly int MagBulletCount;
        public readonly string WeaponName;

        private int _currentMagBulletCount;
        public int CurrentMagBulletCount
        {
            get => _currentMagBulletCount;
            set => _currentMagBulletCount = value < 0 ? 0 : value;
        }


        public bool SwitchedToAuto { get; set; } = false;
        public float MagEmptyTime { get; set; }

        public Weapon(string WeaponName,int magBulletCount, int currentMagBulletCount, bool switchedToAuto, float magEmptyTime)
        {
            MagBulletCount = magBulletCount;
            CurrentMagBulletCount = currentMagBulletCount;
            SwitchedToAuto = switchedToAuto;
            MagEmptyTime = magEmptyTime;
            this.WeaponName = WeaponName;
        }


        public void Shoot()
        {
            Console.WriteLine("One bullet shot!");
            SpareBullet();
        }

        public void Fire()
        {
            if (CurrentMagBulletCount == 0)
            {
                Console.WriteLine("Mag is empty!");
                return;
            }
            if (!SwitchedToAuto) 
            {
                Console.WriteLine("Weaon is in single mode! One bullet shot.");
                SpareBullet();
            }
            else
            {
                var OneBulletTime = MagBulletCount / MagEmptyTime;
                Console.WriteLine($"Mag emptied in {CurrentMagBulletCount*OneBulletTime} sec");
                SpareBullet(MagBulletCount);
            }
        }

        public int GetNeededBulletToFillMagCount()
        {
            return MagBulletCount - CurrentMagBulletCount;
        }

        public void Reload()
        {
            Console.WriteLine("Reloaded!");
            CurrentMagBulletCount = MagBulletCount;
        }
        
        public void ChangeFireMode()
        {
            SwitchedToAuto = !SwitchedToAuto;
            Console.WriteLine($"Switched to { (SwitchedToAuto ? "Auto" : "Single") }");
        }

        private void SpareBullet(int SparedBulletCount = 1)
        {
            if (CurrentMagBulletCount == 0)
            {
                Console.WriteLine("Mag is empty!");
                return;
            }
            CurrentMagBulletCount -=SparedBulletCount;
            CurrentMagBulletCount = CurrentMagBulletCount <= 0 ? 0 : CurrentMagBulletCount;
        }

        public string GetFullInfo()
        {
            return $" {WeaponName} has {CurrentMagBulletCount}/{MagBulletCount} bullets";
        }

    }
}
