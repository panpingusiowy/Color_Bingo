
using System.Windows.Media;

namespace colorRandom
{
    class kolorLista
    {
        public SolidColorBrush kolor { get; set; }
        public string nazwa { get; set; }

        public kolorLista(SolidColorBrush kkolor, string nnazwa)
        {
            kolor = kkolor;
            nazwa = nnazwa;
        }
        public override string ToString()
        {
            return this.nazwa;
        }

    }
}
