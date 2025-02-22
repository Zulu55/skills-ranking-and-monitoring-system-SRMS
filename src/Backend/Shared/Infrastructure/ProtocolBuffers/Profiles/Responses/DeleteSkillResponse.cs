﻿using System.Runtime.Serialization;

namespace Shared.Infrastructure.ProtocolBuffers.Profiles.Responses
{
    [DataContract]
    public class DeleteSkillResponse
    {
        [DataMember(Order = 1)]
        public required string SkillId { get; set; }
    }
}
