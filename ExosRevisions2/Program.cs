namespace ExosRevisions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            World world_instance = new World();
            HeroGroup hero_group_object = new HeroGroup();

            hero_group_object.AddHero(new Warrior("Aric"));
            hero_group_object.AddHero(new Mage("Elara"));

            world_instance.AddLocation(new City("TrappisForge"));
            world_instance.AddLocation(new City("Ardenheim"));

            world_instance.Enter(hero_group_object);
        }
    }
}