function Class_Qbie::onRemove(%this)
{

/*if (%this==%this.Module_ID_Parent.Sprite_Qbie_Player)
{

%this.Module_ID_Parent.ImageFont_Score.dismount();

}*/

for (%x=0;%x<%this.Simset_Qbies_Connected.getCount();%x++)
{

%ScriptObject_Qbies_Connected=%this.Simset_Qbies_Connected.getObject(%x);

if (Scene_Qbies.isJoint(%ScriptObject_Qbies_Connected.Joint_Distance_ID))
{

//Scene_Qbies.deleteJoint(%ScriptObject_Qbies_Connected.Joint_Distance_ID);

//%ScriptObject_Qbies_Connected.Joint_Distance_ID=-1;

}

}

%this.Simset_Qbies_Connected.deleteObjects();

%this.Simset_Qbies_Connected.delete();

Window_Qbies.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}
