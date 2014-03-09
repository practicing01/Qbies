function Gui_Main_Menu::Play(%this)
{

Qbies.Bool_Is_Playing=true;

ModuleDatabase.LoadExplicit("Module_Gameplay");

Module_Gameplay.Scene_Load();

schedule(0,0,"Module_Gui_Main_Menu::Scene_Unload",Module_Gui_Main_Menu);//Bad to use global name instead of handle.

}
