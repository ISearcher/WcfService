using System.Runtime.Serialization;

namespace WcfService.Entity
{
    [DataContract]
    public class CandidateInfo
    {
        [DataMember]
        public string Name;

        [DataMember]
        public string Surname;

        [DataMember]
        public ushort Age;

        [DataMember]
        public ushort Salary;

        [DataMember]
        public ushort Experience;
    }
}