using Microsoft.AspNetCore.Http.HttpResults;
using Nexora.Api.Models;


namespace Nexora.Api.Services
{
    public class SkillsService
    {
        private readonly List<Skill> _skills = new List<Skill>
        {
            new Skill { Id=1, Name="JavaScript", Description="Eine typenfreie Programmiersprache", Logo="../Assets/Logos/JSLogo.png", LogoAlt="JS Logo" },
            new Skill { Id=2, Name="C#", Description="Eine typisierte Programmiersprache", Logo="../Assets/Logos/CSharpLogo.png", LogoAlt="CSharp Logo" },
            new Skill { Id=3, Name="React", Description="Eine typescriptbasiertes Framework", Logo="../Assets/Logos/ReactLogo.png", LogoAlt="React Logo" },
            new Skill { Id=4, Name="Gitarre", Description="Gitarre lernen für Anfänger", Logo="../Assets/Logos/GitarreLogo.png", LogoAlt="Bild einer Gitarre" },
            new Skill { Id=5, Name="Spanisch", Description="Spanisch lernen auf B2 Niveau", Logo="../Assets/Logos/SpanischLogo.png", LogoAlt="Spanische Flagge" },
            new Skill { Id=6, Name="Piano", Description="Klassische Musik auf dem Piano lernen", Logo="../Assets/Logos/PianoLogo.png", LogoAlt="Bild eines Pianos" },
            new Skill { Id=7, Name="Manga zeichnen", Description="Manga zeichnen für Anfänger", Logo="../Assets/Logos/MangaLogo.png", LogoAlt="Bild einer fiktiven Figur" },
        };

        public List<Skill> GetSkillList()
        {
            return _skills;
        }

        public Skill GetSkill(int id)
        {
            return _skills.Find(skill => skill.Id == id);
        }

        public Skill AddNewSkill(Skill skill)
        {
            int id = _skills[^1].Id + 1;

            skill.Id = id;
            _skills.Add(skill);

            return skill;
        }

        public Skill UpdateSkill(int id, Skill skill)
        {
            Skill skillToChange = _skills.Find(skill => skill.Id == id);

            if(skillToChange != null)
            {
                skillToChange.Name = skill.Name;
                skillToChange.Description = skill.Description;
                skillToChange.Logo = skill.Logo;
                skillToChange.LogoAlt = skill.LogoAlt;

                return skillToChange;
            }

            return null;
        }

        public Skill PatchSkill(int id, PatchSkillRequest skill)
        {
            Skill skillToPatch = _skills.Find(skill => skill.Id == id);

            if(skillToPatch != null)
            {
                if (skill.Name != null) skillToPatch.Name = skill.Name;
                if (skill.Description != null) skillToPatch.Description = skill.Description;
                if (skill.Logo != null) skillToPatch.Logo = skill.Logo;
                if (skill.LogoAlt != null) skillToPatch.LogoAlt = skill.LogoAlt;

                return skillToPatch;
            }

            return null;
        }

        public Skill DeleteSkill(int id)
        {
            Skill skillToDelete = _skills.Find(skill => skill.Id == id);

            if (skillToDelete != null)
            {
                _skills.Remove(skillToDelete);

                return skillToDelete;
            }

            return null;
        }

        public Skill GetSkillByName(string name)
        {
            return _skills.Find(skill => skill.Name.ToLower() == name.ToLower());
        }
    }
}