namespace app
{
    class app
    {
        static void Main(string[] args)
        {
            Archer player1 = new Archer("Rodrigo", Element.Fire);
            Warrior player2 = new Warrior("Rafael", Element.Air);
            Mage player3 = new Mage("Victoria", Element.Earth);
            Cleric player4 = new Cleric("Gabriel", Element.Light);

            World.players.Add (player1);
            World.players.Add (player2);
            World.players.Add (player3);
            World.players.Add (player4);

            Combat combat = new Combat();
            combat.CreateCombat(new Monster("Aranha", 20, 30, Element.Shadow));
        }
    }
}
