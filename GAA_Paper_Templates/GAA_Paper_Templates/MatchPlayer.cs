//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAA_Paper_Templates
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatchPlayer
    {
        public int ID { get; set; }
        public int Goals { get; set; }
        public int Penalties { get; set; }
        public int Points { get; set; }
        public int Frees { get; set; }
        public bool IsSubbed { get; set; }
        public int MinuteOn { get; set; }
        public int MinuteOff { get; set; }
        public int PlayerNumber { get; set; }
        public int SubbedFor { get; set; }
        public int YellowCards { get; set; }
        public int BlackCards { get; set; }
        public int RedCards { get; set; }
        public bool IsSentOff { get; set; }
    
        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
