using System;
using System.Collections.Generic;
/// <summary>
/// Шаблон Memento(Хранитель) на игровом примере
/// </summary>
namespace PatternMemento
{
    /// <summary>
    /// Класс, состояние которого нужно сохранить
    /// </summary>
    class Hero
    {
        #region Fields
        private string weapon = "none";
        private string armor = "none";
        private long gold = 10;
        #endregion
        #region Methods
        public void Attack() { Console.WriteLine("Hit!"); gold++; }
        public void Protect() { Console.WriteLine("Protect!"); gold--; }
        public void BuyWeapon(string weapon) { this.weapon = weapon; gold -= 10; }
        public void BuyArmor(string armor) { this.armor = armor; gold -= 10; }
        #endregion
        /// <summary>
        /// Метод сохраняет состояние текущего объекта в новый экземпляр класса Memento.
        /// </summary>
        /// <returns> экземпляр класса для хранения состояния </returns>
        public HeroMemento SaveState() => new HeroMemento(weapon, armor, gold);
        /// <summary>
        /// Востанавливает состояние из переданного Memento.
        /// </summary>
        /// <param name="memento">объект с сохранённым состоянием</param>
        public void RestoreState(HeroMemento memento)
        {
            this.weapon = memento.Weapon;
            this.armor = memento.Armor;
            this.gold = memento.Gold;
        }
        public override string ToString() => string.Format("Armor: {0}, Weapon: {1} Gold: {2}", armor, weapon, gold);
    }
    /// <summary>
    /// Memento. Класс, который хранит состояние объекта Hero. 
    /// Информацию о состоянии можно получить через свойства.
    /// </summary>
    class HeroMemento
    {
        #region Properties
        public string Weapon { get; private set; }
        public string Armor { get; private set; }
        public long Gold { get; private set; }
        #endregion
        public HeroMemento(string weapon, string armor, long gold)
        {
            Weapon = weapon; Armor = armor; Gold = gold;
        }
    }
    /// <summary>
    /// Только хранит состание объекта!!
    /// </summary>
    class HistorySaves
    {
        /// <summary>
        /// Стек для того, чтобы было удобнее доставать последнее состояние объекта
        /// </summary>
        public Stack<HeroMemento> History { get; set; }
        public HistorySaves()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
