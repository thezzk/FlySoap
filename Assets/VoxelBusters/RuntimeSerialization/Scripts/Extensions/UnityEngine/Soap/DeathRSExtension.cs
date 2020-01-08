using UnityEngine;
using System.Collections;
using VoxelBusters.RuntimeSerialization;
using Acrocatic;
public class DeathRSExtension : ComponentRSExtension
{

    #region Constants




    #endregion
    #region Serialization Methods
    public override void WriteSerializationData (object _object, RuntimeSerializationInfo _info){
        Death   _death  = _object as Death;

        if (_death == null)
            return;

        UIDSystem   _UIDSystem  = _death.GetComponent<UIDSystem>();

        if (_UIDSystem == null)
        {
            Debug.LogError(string.Format("[RS] UIDSystem not found in GameObject with name {0}. Please add UIDSystem component to serializing object.", _death.name), _death);
            return;
        }

        // Serialize base properties
        base.WriteSerializationData(_object, _info);

        //        // Serializing properties


        // Serialize immediate childrens

    }

    public override object ReadSerializationData (object _object, RuntimeSerializationInfo _info){
        Death _death        = base.ReadSerializationData(_object, _info) as Death;

        if (_death == null)
            return null;
       
        return _death;
    }
    #endregion
}

