function Module_Gameplay::Qbie_Traverse_Connection_Tree(%this,%SimSet_Unique_Qbies,%Sprite_Qbie_Root)
{

%Int_Connected_Qbie_Count=0;

for (%x=0;%x<%Sprite_Qbie_Root.Simset_Qbies_Connected.getCount();%x++)
{

%Sprite_Qbie_Root_Connected=%Sprite_Qbie_Root.Simset_Qbies_Connected.getObject(%x);

if (!%SimSet_Unique_Qbies.isMember(%Sprite_Qbie_Root_Connected.Sprite_Qbie))
{

%SimSet_Unique_Qbies.add(%Sprite_Qbie_Root_Connected.Sprite_Qbie);

%Int_Connected_Qbie_Count++;

%Int_Connected_Qbie_Count+=%this.Qbie_Traverse_Connection_Tree(%SimSet_Unique_Qbies,%Sprite_Qbie_Root_Connected.Sprite_Qbie);

}

}

return %Int_Connected_Qbie_Count;

}
