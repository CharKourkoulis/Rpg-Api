using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Controllers.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

         private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Conan" }
        };


        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return  characters;
        }

        public async Task<List<Character>> GetAllCharacters() => characters;


        public async Task<Character> GetCharacterById(int id) =>
          characters.FirstOrDefault(c => c.Id == id);
       
    }
}