﻿using System.Threading.Tasks;
using EMBC.DFA.Managers.Intake;

namespace EMBC.DFA.Resources.Submissions
{
    public interface ISubmissionsRepository
    {
        Task<string> Manage(Command form);
    }

    public abstract class Command
    {
    }

    public class SubmitSmbFormCommand : Command
    {
        public SmbForm Form { get; set; } = null!;
    }

    public class SubmitIndFormCommand : Command
    {
        public SmbForm Form { get; set; } = null!;
    }

    public class SubmitGovFormCommand : Command
    {
        public SmbForm Form { get; set; } = null!;
    }
}