function Class_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Qbie")
{

/**************************************************************************/
//Check if all qbies are connected, that's the win condition.

%Int_Connected_Qbie_Count=0;

%SimSet_Unique_Qbies=new SimSet();

for (%x=0;%x<%this.Module_ID_Parent.Simset_Qbies_Connected_To_Player.getCount();%x++)
{

%Sprite_Qbie=%this.Module_ID_Parent.Simset_Qbies_Connected_To_Player.getObject(%x);

if (!%SimSet_Unique_Qbies.isMember(%Sprite_Qbie))
{

%SimSet_Unique_Qbies.add(%Sprite_Qbie);

%Int_Connected_Qbie_Count++;

}

%Int_Connected_Qbie_Count+=%this.Module_ID_Parent.Qbie_Traverse_Connection_Tree(%SimSet_Unique_Qbies,%Sprite_Qbie);

}

%SimSet_Unique_Qbies.delete();

if (%Int_Connected_Qbie_Count==%this.Module_ID_Parent.Int_Qbie_Total)
{

if (%this.Module_ID_Parent.Schedule_Win==0)
{

%this.Module_ID_Parent.Schedule_Win=schedule(0,0,"Gui_Gameplay_Menu::Go_Main_Menu",Gui_Gameplay_Menu);

}

}

}

}
