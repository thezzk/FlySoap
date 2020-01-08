using UnityEngine;
using System.Collections;
using Acrocatic;
using VoxelBusters.RuntimeSerialization;
public class ShowColliderRSExtension : ComponentRSExtension
{

    #region Constants




    #endregion
    #region Serialization Methods
    public override void WriteSerializationData (object _object, RuntimeSerializationInfo _info){
        ShowCollider   _showCollider  = _object as ShowCollider;

        if (_showCollider == null)
            return;

        UIDSystem   _UIDSystem  = _showCollider.GetComponent<UIDSystem>();

        if (_UIDSystem == null)
        {
            Debug.LogError(string.Format("[RS] UIDSystem not found in GameObject with name {0}. Please add UIDSystem component to serializing object.", _showCollider.name), _showCollider);
            return;
        }

        // Serialize base properties
        base.WriteSerializationData(_object, _info);

        //        // Serializing properties


        // Serialize immediate childrens

    }

    public override object ReadSerializationData (object _object, RuntimeSerializationInfo _info){
        ShowCollider _showCollider        = base.ReadSerializationData(_object, _info) as ShowCollider;

        if (_showCollider == null)
            return null;

        return _showCollider;
    }
    #endregion

}

