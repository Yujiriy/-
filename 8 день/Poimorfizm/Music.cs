using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poimorfizm
{
    using System.Media;
    using System.Threading;
    // Абстрактный класс MusicalInstrument
    using System.Windows.Forms;

    public abstract class MusicalInstrument
    {
        public string Name { get; set; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }

        public abstract void Play(ListBox listBox);
    }

    public class Percussion : MusicalInstrument
    {
        public string DrumType { get; set; }

        public Percussion(string name, string drumType) : base(name)
        {
            DrumType = drumType;
        }

        public override void Play(ListBox listBox)
        {
            listBox.Items.Add($"Playing percussion instrument: {Name} ({DrumType})");
        }
    }

    public class Stringed : MusicalInstrument
    {
        public int NumberOfStrings { get; set; }

        public Stringed(string name, int numberOfStrings) : base(name)
        {
            NumberOfStrings = numberOfStrings;
        }

        public override void Play(ListBox listBox)
        {
            listBox.Items.Add($"Playing stringed instrument: {Name}, Strings: {NumberOfStrings}");
            
        }


    }

    public class Wind : MusicalInstrument
    {
        public string WindType { get; set; }

        public Wind(string name, string windType) : base(name)
        {
            WindType = windType;
        }

        public override void Play(ListBox listBox)
        {
            listBox.Items.Add($"Playing wind instrument: {Name}, Type: {WindType}");
        }
    }


}
