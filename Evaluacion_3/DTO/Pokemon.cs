using System;
using System.Collections;

namespace Evaluacion_3
{
    public class Pokemon
    {
        private int num;
        private String nombre;
        private String tipoPrincipal;
        private String tipoSecundario;
        public Pokemon()
        {

        }
        //getters
        public int getNum()
        {
            return this.num;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getTipoPrincipal()
        {
            return this.tipoPrincipal;
        }

        public String getTipoSecundario()
        {
            return this.tipoSecundario;
        }

        //setters
        public void setNum(int num)
        {
            this.num = num;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setTipoPrincipal(String tipoPrincipal)
        {
            this.tipoPrincipal = tipoPrincipal;
        }

        public void setTipoSecundario(String tipoSecundario)
        {
            this.tipoSecundario = tipoSecundario;
        }

        public Pokemon setPokemon(int num, String nombre, String tipoPrincipal, String tipoSecundario)
        {
            Pokemon p = new Pokemon();
            p.setNum(num);
            p.setNombre(nombre);
            p.setTipoPrincipal(tipoPrincipal);
            p.setTipoSecundario(tipoSecundario);

            return p;
        }
        public ArrayList initialPokemon()
        {
            ArrayList arrayPokemon = new ArrayList();
            arrayPokemon.Add(setPokemon(1, "Bulbasaur", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(2, "Ivysaur", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(3, "Venasaur", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(4, "Charmander", "Fuego", ""));
            arrayPokemon.Add(setPokemon(5, "Charmeleon", "Fuego", ""));
            arrayPokemon.Add(setPokemon(6, "Charizard", "Fuego", "Volador"));
            arrayPokemon.Add(setPokemon(7, "Squirtle", "Agua", ""));
            arrayPokemon.Add(setPokemon(8, "Wartortle", "Agua", ""));
            arrayPokemon.Add(setPokemon(9, "Blastoise", "Agua", ""));
            arrayPokemon.Add(setPokemon(10, "Caterpie", "Bicho", ""));
            arrayPokemon.Add(setPokemon(11, "Metapod", "Bicho", ""));
            arrayPokemon.Add(setPokemon(12, "Butterfree", "Bicho", "Volador"));
            arrayPokemon.Add(setPokemon(13, "Weedle", "Bicho", "Veneno"));
            arrayPokemon.Add(setPokemon(14, "Kakuna", "Bicho", "Veneno"));
            arrayPokemon.Add(setPokemon(15, "Beedril", "Bicho", "Veneno"));
            arrayPokemon.Add(setPokemon(16, "Pidgey", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(17, "Pidgeotto", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(18, "Pidgeot", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(19, "Rattata", "Normal", ""));
            arrayPokemon.Add(setPokemon(20, "Raticate", "Normal", ""));
            arrayPokemon.Add(setPokemon(21, "Spearow", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(22, "Fearow", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(23, "Ekans", "Veneno", ""));
            arrayPokemon.Add(setPokemon(24, "Arbok", "Veneno", ""));
            arrayPokemon.Add(setPokemon(25, "Pikachu", "Electrico", ""));
            arrayPokemon.Add(setPokemon(26, "Raichu", "Electrico", ""));
            arrayPokemon.Add(setPokemon(27, "Sandshrew", "Tierra", ""));
            arrayPokemon.Add(setPokemon(28, "Sandslash", "Tierra", ""));
            arrayPokemon.Add(setPokemon(29, "Nidoran ♀", "Veneno", ""));
            arrayPokemon.Add(setPokemon(30, "Nidorina", "Veneno", ""));
            arrayPokemon.Add(setPokemon(31, "Nidoqueen", "Veneno", "Tierra"));
            arrayPokemon.Add(setPokemon(32, "Nidoran ♂", "Veneno", ""));
            arrayPokemon.Add(setPokemon(33, "Nidorino", "Veneno", ""));
            arrayPokemon.Add(setPokemon(34, "Nidoking", "Veneno", "Tierra"));
            arrayPokemon.Add(setPokemon(35, "Clefairy", "Normal", ""));
            arrayPokemon.Add(setPokemon(36, "Clefable", "Normal", ""));
            arrayPokemon.Add(setPokemon(37, "Vulpix", "Fuego", ""));
            arrayPokemon.Add(setPokemon(38, "Ninetales", "Fuego", ""));
            arrayPokemon.Add(setPokemon(39, "Jigglypuff", "Normal", ""));
            arrayPokemon.Add(setPokemon(40, "Wigglytuff", "Normal", ""));
            arrayPokemon.Add(setPokemon(41, "Zubat", "Veneno", "Volador"));
            arrayPokemon.Add(setPokemon(42, "Golbat", "Veneno", "Volador"));
            arrayPokemon.Add(setPokemon(43, "Oddish", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(44, "Gloom", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(45, "Vileplume", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(46, "Paras", "Bicho", "Planta"));
            arrayPokemon.Add(setPokemon(47, "Parasect", "Bicho", "Planta"));
            arrayPokemon.Add(setPokemon(48, "Venonat", "Bicho", "Veneno"));
            arrayPokemon.Add(setPokemon(49, "Venomoth", "Bicho", "Veneno"));
            arrayPokemon.Add(setPokemon(50, "Diglett", "Tierra", ""));
            arrayPokemon.Add(setPokemon(51, "Dugtrio", "Tierra", ""));
            arrayPokemon.Add(setPokemon(52, "Meowth", "Normal", ""));
            arrayPokemon.Add(setPokemon(53, "Persian", "Normal", ""));
            arrayPokemon.Add(setPokemon(54, "Psyduck", "Agua", ""));
            arrayPokemon.Add(setPokemon(55, "Golduck", "Agua", ""));
            arrayPokemon.Add(setPokemon(56, "Mankey", "Lucha", ""));
            arrayPokemon.Add(setPokemon(57, "Primeate", "Lucha", ""));
            arrayPokemon.Add(setPokemon(58, "Growlithe", "Fuego", ""));
            arrayPokemon.Add(setPokemon(59, "Arcanine", "Fuego", ""));
            arrayPokemon.Add(setPokemon(60, "Poliwag", "Agua", ""));
            arrayPokemon.Add(setPokemon(61, "Poliwhirl", "Agua", ""));
            arrayPokemon.Add(setPokemon(62, "Poliwrath", "Agua", "Lucha"));
            arrayPokemon.Add(setPokemon(63, "Abra", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(64, "Kadabra", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(65, "Alakazam", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(66, "Machop", "Lucha", ""));
            arrayPokemon.Add(setPokemon(67, "Machoke", "Lucha", ""));
            arrayPokemon.Add(setPokemon(68, "Machamp", "Lucha", ""));
            arrayPokemon.Add(setPokemon(69, "Bellsprout", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(70, "Weepinbell", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(71, "Victreebel", "Planta", "Veneno"));
            arrayPokemon.Add(setPokemon(72, "Tentacool", "Agua", "Veneno"));
            arrayPokemon.Add(setPokemon(73, "Tentacruel", "Agua", "Veneno"));
            arrayPokemon.Add(setPokemon(74, "Geodude", "Roca", "Tierra"));
            arrayPokemon.Add(setPokemon(75, "Graveler", "Roca", "Tierra"));
            arrayPokemon.Add(setPokemon(76, "Golem", "Roca", "Tierra"));
            arrayPokemon.Add(setPokemon(77, "Ponyta", "Fuego", ""));
            arrayPokemon.Add(setPokemon(78, "Rapidash", "Fuego", ""));
            arrayPokemon.Add(setPokemon(79, "Slowpoke", "Agua", "Psiquico"));
            arrayPokemon.Add(setPokemon(80, "Slowbro", "Agua", "Psiquico"));
            arrayPokemon.Add(setPokemon(81, "Magnemite", "Electrico", "Acero"));
            arrayPokemon.Add(setPokemon(82, "Magneton", "Electrico", "Acero"));
            arrayPokemon.Add(setPokemon(83, "Farfetch'd", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(84, "Doduo", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(85, "Dodrio", "Normal", "Volador"));
            arrayPokemon.Add(setPokemon(86, "Seel", "Agua", ""));
            arrayPokemon.Add(setPokemon(87, "Dewgong", "Agua", "Hielo"));
            arrayPokemon.Add(setPokemon(88, "Grimer", "Veneno", ""));
            arrayPokemon.Add(setPokemon(89, "Muk", "Veneno", ""));
            arrayPokemon.Add(setPokemon(90, "Shelder", "Agua", ""));
            arrayPokemon.Add(setPokemon(91, "Cloyster", "Agua", "Hielo"));
            arrayPokemon.Add(setPokemon(92, "Gastly", "Fantasma", "Veneno"));
            arrayPokemon.Add(setPokemon(93, "Haunter", "Fantasma", "Veneno"));
            arrayPokemon.Add(setPokemon(94, "Gengar", "Fantasma", "Veneno"));
            arrayPokemon.Add(setPokemon(95, "Onix", "Roca", "Tierra"));
            arrayPokemon.Add(setPokemon(96, "Drowzee", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(97, "Hypno", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(98, "Krabby", "Agua", ""));
            arrayPokemon.Add(setPokemon(99, "Kingler", "Agua", ""));
            arrayPokemon.Add(setPokemon(100, "Voltorb", "Electrico", ""));
            arrayPokemon.Add(setPokemon(101, "Electrode", "Electrico", ""));
            arrayPokemon.Add(setPokemon(102, "Exeggcute", "Planta", "Psiquico"));
            arrayPokemon.Add(setPokemon(103, "Exeggutor", "Planta", "Psiquico"));
            arrayPokemon.Add(setPokemon(104, "Cubone", "Tierra", ""));
            arrayPokemon.Add(setPokemon(105, "Marowak", "Tierra", ""));
            arrayPokemon.Add(setPokemon(106, "Hitmonlee", "Lucha", ""));
            arrayPokemon.Add(setPokemon(107, "Hitmonchan", "Lucha", ""));
            arrayPokemon.Add(setPokemon(108, "Lickitung", "Normal", ""));
            arrayPokemon.Add(setPokemon(109, "Koffing", "Veneno", ""));
            arrayPokemon.Add(setPokemon(110, "Weezing", "Veneno", ""));
            arrayPokemon.Add(setPokemon(111, "Ryhorn", "Tierra", "Roca"));
            arrayPokemon.Add(setPokemon(112, "Rydon", "Tierra", "Roca"));
            arrayPokemon.Add(setPokemon(113, "Chansey", "Normal", ""));
            arrayPokemon.Add(setPokemon(114, "Tangela", "Planta", ""));
            arrayPokemon.Add(setPokemon(115, "Kangaskhan", "Normal", ""));
            arrayPokemon.Add(setPokemon(116, "Horsea", "Agua", ""));
            arrayPokemon.Add(setPokemon(117, "Seadra", "Agua", ""));
            arrayPokemon.Add(setPokemon(118, "Goldeeen", "Agua", ""));
            arrayPokemon.Add(setPokemon(119, "Seaking", "Agua", ""));
            arrayPokemon.Add(setPokemon(120, "Staryu", "Agua", ""));
            arrayPokemon.Add(setPokemon(121, "Starmie", "Agua", "Psiquico"));
            arrayPokemon.Add(setPokemon(122, "Mr. Mime", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(123, "Schyther", "Bicho", "Volador"));
            arrayPokemon.Add(setPokemon(124, "Jynx", "Hielo", "Psiquico"));
            arrayPokemon.Add(setPokemon(125, "Electabuzz", "Electrico", ""));
            arrayPokemon.Add(setPokemon(126, "Magmar", "Fuego", ""));
            arrayPokemon.Add(setPokemon(127, "Pinsir", "Bicho", ""));
            arrayPokemon.Add(setPokemon(128, "Tauros", "Normal", ""));
            arrayPokemon.Add(setPokemon(129, "Magikarp", "Agua", ""));
            arrayPokemon.Add(setPokemon(130, "Gyarados", "Agua", "Volador"));
            arrayPokemon.Add(setPokemon(131, "Lapras", "Agua", "Hielo"));
            arrayPokemon.Add(setPokemon(132, "Ditto", "Normal", ""));
            arrayPokemon.Add(setPokemon(133, "Eeve", "Normal", ""));
            arrayPokemon.Add(setPokemon(134, "Vaporeon", "Agua", ""));
            arrayPokemon.Add(setPokemon(135, "Jolteon", "Electrico", ""));
            arrayPokemon.Add(setPokemon(136, "Flareon", "Fuego", ""));
            arrayPokemon.Add(setPokemon(137, "Porygon", "Normal", ""));
            arrayPokemon.Add(setPokemon(138, "Omanyte", "Roca", "Agua"));
            arrayPokemon.Add(setPokemon(139, "Omastar", "Roca", "Agua"));
            arrayPokemon.Add(setPokemon(140, "Kabuto", "Roca", "Agua"));
            arrayPokemon.Add(setPokemon(141, "Kabutops", "Roca", "Agua"));
            arrayPokemon.Add(setPokemon(142, "Aerodactyl", "Roca", "Volador"));
            arrayPokemon.Add(setPokemon(143, "Snorlax", "Normal", ""));
            arrayPokemon.Add(setPokemon(144, "Articuno", "Hielo", "Volador"));
            arrayPokemon.Add(setPokemon(145, "Zapdos", "Electrico", "Volador"));
            arrayPokemon.Add(setPokemon(146, "Moltres", "Fuego", "Volador"));
            arrayPokemon.Add(setPokemon(147, "Dratini", "Dragon", ""));
            arrayPokemon.Add(setPokemon(148, "Dragonair", "Dragon", ""));
            arrayPokemon.Add(setPokemon(149, "Dragonite", "Dragon", "Volador"));
            arrayPokemon.Add(setPokemon(150, "Mewtwo", "Psiquico", ""));
            arrayPokemon.Add(setPokemon(151, "Mew", "Psiquico", ""));
            return arrayPokemon;
        }
    }
}