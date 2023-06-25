using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Player : Personagem
    {
        public int Experiencia { get; set; }
        public int Nivel { get; set; }
        public int[] Localização { get; set; }
        public string ClasseLuta { get; set; }
        public int[] ExpNivel { get; set; }
        public List<Itens> Itens { get; set; }

        public Player()
        {
        }

        public Player(string nome,string classe,Habilidade habilidade)
        {
            Nome = nome;
            ClasseLuta = Classe;
            Nivel = 1;
            Experiencia = 1;
            Localização = new int[] { 1,1 };
            Ataque = 10;
            Defesa = 10;
            HP = 50;
            ExpNivel = new int[] { 30,60,90,150,200 };
            Itens = new List<Itens>();
        }

        public override int CalcularDano()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(1,3);

            if (numeroSorteado == 1) return ((base.CalcularDano() * Nivel) * 2);
            return (Ataque * Nivel);
        }

        public int SetNivel()
        {
            if (Experiencia <= 30)
            {
                Nivel = 1;
                Ataque *= Nivel;
                return Nivel;
            }

            if (Experiencia > 30 && Experiencia <= 40)
            {
                Nivel = 2;
                Ataque *= Nivel;
                return Nivel;
            }

            else if (Experiencia > 40)
            {
                Nivel = 3;
                Ataque *= Nivel;
                return Nivel;
            }
            Nivel = 0;
            return Nivel;
        }
    }
}
