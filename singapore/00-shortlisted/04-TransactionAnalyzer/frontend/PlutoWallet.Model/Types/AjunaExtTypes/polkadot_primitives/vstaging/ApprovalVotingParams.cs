//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.polkadot_primitives.vstaging
{
    
    
    /// <summary>
    /// >> 327 - Composite[polkadot_primitives.vstaging.ApprovalVotingParams]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ApprovalVotingParams : BaseType
    {
        
        /// <summary>
        /// >> max_approval_coalesce_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxApprovalCoalesceCount { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ApprovalVotingParams";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxApprovalCoalesceCount.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxApprovalCoalesceCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxApprovalCoalesceCount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}