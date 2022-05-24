namespace CodeExample
{
    public class Pokemon
    {
        // backing fields -- these will back the properties (declared below)
        // C# coding standards note an underscore at the beginning of the field's name
        private int _dexNumber;
        private string? _name = string.Empty;
        
        // The Types property is auto-implemented, so C# will transparently
        // create the backing field for us, rendering the following statement redundant
        
        // private string[]? _types;

        // properties -- just like methods (because they are methods), properties
        // use PascalCase

        public int DexNumber
        {
            get { return _dexNumber; }
            init
            {
                if (value < 1 || value > 905)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 1 and 905.");
                }
                _dexNumber = value;
            }
        }

        // expression body definitions
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // auto-implemented property
        public string[] Types { get; set; }
        public decimal HP { get; set; }

        // Constructor(s)
        public Pokemon() { }

        public Pokemon(int dexNumber, string? name, string[] types, decimal hP)
        {
            DexNumber = dexNumber;
            Name = name;
            Types = types;
            HP = hP;
        }

        // copy constructor
        public Pokemon(Pokemon pokemonToCopy)
        {
            DexNumber = pokemonToCopy.DexNumber;
            Name = pokemonToCopy.Name;
            Types = pokemonToCopy.Types;
            HP = pokemonToCopy.HP;
        }

        public void TakeDamage(int dmg, decimal modifier = 1.0M)
        {
            HP -= (dmg * modifier);

            if(HP <= 0)
            {
                Faint();
            }
        }

        public string Faint()
        {
            return $"{Name} blacked out! Uh-oh...";
        }

        public override string ToString()
        {
            return 
                $"--------------------------------\n" +
                $"Dex No.:\t{DexNumber}\n" +
                $"Name:\t\t{Name}\n" +
                $"Types:\t\t{string.Join(",", Types)}\n" +
                $"HP:\t\t{HP}\n" +
                $"--------------------------------\n";
        }
    }
}
