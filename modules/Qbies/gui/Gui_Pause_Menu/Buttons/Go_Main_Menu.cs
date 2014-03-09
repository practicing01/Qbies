function Gui_Pause_Menu::Go_Main_Menu(%this)
{

Qbies.Module_Gameplay.Scene_Unload();

Qbies.Module_Gameplay=0;

/***********************************************/
/************ Delete Gui's **********************/

for (%x=0;%x<Gui_Qbies_Overlay.getCount();%x++)
{

%Gui_Child=Gui_Qbies_Overlay.getObject(%x);

if (%Gui_Child.Bool_Delete_Me==true)
{

Gui_Qbies_Overlay.remove(%Gui_Child);

%Gui_Child.deleteObjects();

%Gui_Child.delete();

%x=-1;//Restart loop because we just modified the count.

}

}

/***********************************************/

Qbies.Bool_Is_Playing=false;

Canvas.popDialog(Gui_Pause_Menu);

Module_Gui_Main_Menu.Scene_Load();

}
