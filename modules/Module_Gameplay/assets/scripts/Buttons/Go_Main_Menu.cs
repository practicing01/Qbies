function Gui_Gameplay_Menu::Go_Main_Menu(%this)
{

for (%x=0;%x<Module_Gameplay.Simset_Qbies.getCount();%x++)
{

%Sprite_Qbie=Module_Gameplay.Simset_Qbies.getObject(%x);

if (Scene_Qbies.isJoint(%Sprite_Qbie.Joint_Target_ID))
{

//Scene_Qbies.deleteJoint(%Sprite_Qbie.Joint_Target_ID);

//%Sprite_Qbie.Joint_Target_ID=-1;

}

for (%y=0;%y<%Sprite_Qbie.Simset_Qbies_Connected.getCount();%y++)
{

%ScriptObject_Connected_Qbie=%Sprite_Qbie.Simset_Qbies_Connected.getObject(%y);

if (Scene_Qbies.isJoint(%ScriptObject_Connected_Qbie.Joint_Distance_ID))
{

//Scene_Qbies.deleteJoint(%ScriptObject_Connected_Qbie.Joint_Distance_ID);

//%ScriptObject_Connected_Qbie.Joint_Distance_ID=-1;

}

}

}

schedule(0,0,"Gui_Pause_Menu::Go_Main_Menu",Gui_Pause_Menu);

}
