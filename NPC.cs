using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCWorld
{
	internal class NPC
	{
		private int lp = 100;
		protected string name = "Unbekannter";
		protected string[] dialogue = { "..." };

		public int Lp { get => lp; set => lp = value; }
		public string Name { get => name; }
		public string[] Dialogue { get => dialogue;}		

		public NPC()
		{

		}

		public NPC(int lp, string name, string[] dialogue) 
		{
			this.lp = lp;
			this.name = name;
			this.dialogue = dialogue;
		}

		public void Interact(NPC npc)
		{
            foreach(string text in dialogue)
			{
				string output = "";
				foreach(char i in text)
				{
					output += i;
					Console.Clear();
					Console.WriteLine(output);
					Thread.Sleep(30);
			
				}   
				Console.ReadKey();
				Console.Clear();
			}
			if(npc is NPCFriend friend)
			{
				friend.Trade();
			}
			else if(npc is NPCEnemy enemy)
			{
				enemy.Fight();
			}
        }
	}
}
