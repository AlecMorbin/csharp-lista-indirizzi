using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private string via;
        private string city;
        private string province;
        private int zip;

        public Persona(string nome, string cognome, string via, string city, string province, int zip)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.cognome = cognome ?? throw new ArgumentNullException(nameof(cognome));
            this.via = via ?? throw new ArgumentNullException(nameof(via));
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.province = province ?? throw new ArgumentNullException(nameof(province));
            this.zip = zip;
        }

        public override string? ToString()
        {
            return "-------Persona-------" + "\n" +
                    "Nome: " + nome + "\n" +
                    "Cognome: " + cognome + "\n" +
                    "Via: " + via + "\n" +
                    "Città: " + city + "\n" +
                    "Province: " + province + "\n" +
                    "ZIP: " + zip + "\n" ;
        }
    }
}
