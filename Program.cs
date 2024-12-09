namespace NPCWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Erstelle eine Klasse NPC mit den Feldern Dialog Lebenspunkte und Name.
			//Erstelle eine Methode um mit dem NPC zu interagieren bzw um ausgaben aus dem Feld Dialog zu generieren
			//Es sollen auf Basis dieser Klasse zwei Kind-Klassen erzeugt werden und zwar NPCFeind und NPCFreund
			//Bei einem freundlichen NPC soll es eine möglichkeit geben zu handeln (Trading muss nicht implementiert werden) lediglich Ausgabe
			//Bei einem feindlichen NPC soll es zu einem Kampf kommen (Daselbe wie beim Trading)
			//Erstellt aus den Kindklassen 4 Objekte also 2 freundliche NPCs und zwei feindliche.
			//Erstelle in der Program.cs eine Methode um auf die verschiedenen NPCs zuzugreifen bzw. mit diesen zu Interagieren.


			//Für Fortgeschrittene implemtiert Handeln und Kämpfen passt dafür die Felder ggf. an 

			//Tipp: Für das Inventory recherchieren zum Thema Listen bzw dynamische Listen
			Menu();
			

		}

		public static void Menu()
		{
			NPCFriend npc1 = new NPCFriend(50, "Maria", ["Hallo ich bin Maria aus Flusswald.", "Warst du schon mal in Flusswald?", "Ich habe einige Wahren von dort die ich zum Handeln anbiete."]);
			NPCFriend npc2 = new NPCFriend(200, "Alfred", ["Ich verkaufe dir die besten Wahren", "Ich weiß nicht wem sie vorher gehört haben.", "Was sagst du dazu?"]);
			NPCEnemy npc3 = new NPCEnemy(300, "Böser Bär", ["Grrrrrr"]);
			NPCEnemy npc4 = new NPCEnemy(120, "Fitz der Argonier", ["Dein Gold ...", "UND DEIN LEBEN!"]);

			while (true) 
			{ 
				Console.Clear();
                Console.WriteLine($"Mir welchem NPC möchtest du interagieren? (1 - 4)\n\n1.{npc1.Name}\n2.{npc2.Name}\n3.{npc3.Name}\n4.{npc4.Name}\n");
				string input = Console.ReadLine();

				if( input == "1")npc1.Interact(npc1);
				else if(input == "2")npc2.Interact(npc2);
				else if (input == "3") npc3.Interact(npc3);
				else if (input == "4") npc4.Interact(npc4);
				else
				{
					Console.WriteLine("Eingabe ist ungültig");
				}


            }

		}
	}
}
