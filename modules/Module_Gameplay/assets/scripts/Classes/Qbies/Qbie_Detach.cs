function Class_Qbie::Qbie_Detach(%this,%Sprite_Qbie)
{

if (%Sprite_Qbie!=%this)
{

for (%x=0;%x<%this.Simset_Qbies_Connected.getCount();%x++)
{

%ScriptObject_Qbies_Connected=%this.Simset_Qbies_Connected.getObject(%x);

if (%ScriptObject_Qbies_Connected.Sprite_Qbie==%Sprite_Qbie)
{

if (Scene_Qbies.isJoint(%ScriptObject_Qbies_Connected.Joint_Distance_ID))
{

Scene_Qbies.deleteJoint(%ScriptObject_Qbies_Connected.Joint_Distance_ID);

%ScriptObject_Qbies_Connected.Joint_Distance_ID=-1;

}

%this.Simset_Qbies_Connected.remove(%ScriptObject_Qbies_Connected);

break;

}

}

return;

}

/****************************************************************************/

if (%this!=%this.Module_ID_Parent.Sprite_Qbie_Player)
{

%this.Bool_Connected_To_Qbie_Player=false;

if (%this.Module_ID_Parent.Simset_Qbies_Connected_To_Player.isMember(%this))
{

%this.Module_ID_Parent.Simset_Qbies_Connected_To_Player.remove(%this);

}

}

for (%x=0;%x<%this.Simset_Qbies_Connected.getCount();%x++)
{

%ScriptObject_Qbies_Connected=%this.Simset_Qbies_Connected.getObject(%x);

if (Scene_Qbies.isJoint(%ScriptObject_Qbies_Connected.Joint_Distance_ID))
{

Scene_Qbies.deleteJoint(%ScriptObject_Qbies_Connected.Joint_Distance_ID);

%ScriptObject_Qbies_Connected.Joint_Distance_ID=-1;

}

%ScriptObject_Qbies_Connected.Sprite_Qbie.Qbie_Detach(%this);

}

%this.Simset_Qbies_Connected.deleteObjects();

}
