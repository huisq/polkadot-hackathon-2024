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


namespace Opal.NetApi.Generated.Model.up_pov_estimate_rpc
{
    
    
    /// <summary>
    /// >> 609 - Composite[up_pov_estimate_rpc.PovInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PovInfo : BaseType
    {
        
        /// <summary>
        /// >> proof_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 ProofSize { get; set; }
        /// <summary>
        /// >> compact_proof_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 CompactProofSize { get; set; }
        /// <summary>
        /// >> compressed_proof_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 CompressedProofSize { get; set; }
        /// <summary>
        /// >> results
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Types.Base.EnumResult> Results { get; set; }
        /// <summary>
        /// >> key_values
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.up_pov_estimate_rpc.TrieKeyValue> KeyValues { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PovInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ProofSize.Encode());
            result.AddRange(CompactProofSize.Encode());
            result.AddRange(CompressedProofSize.Encode());
            result.AddRange(Results.Encode());
            result.AddRange(KeyValues.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ProofSize = new Substrate.NetApi.Model.Types.Primitive.U64();
            ProofSize.Decode(byteArray, ref p);
            CompactProofSize = new Substrate.NetApi.Model.Types.Primitive.U64();
            CompactProofSize.Decode(byteArray, ref p);
            CompressedProofSize = new Substrate.NetApi.Model.Types.Primitive.U64();
            CompressedProofSize.Decode(byteArray, ref p);
            Results = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Types.Base.EnumResult>();
            Results.Decode(byteArray, ref p);
            KeyValues = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.up_pov_estimate_rpc.TrieKeyValue>();
            KeyValues.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}