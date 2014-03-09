function Module_Gameplay::Scene_Unload(%this)
{

%this.Simset_Qbies.deleteObjects();

%this.Simset_Qbies.delete();

%this.Simset_Qbies_Connected_To_Player.deleteObjects();

%this.Simset_Qbies_Connected_To_Player.delete();

Canvas.popDialog(Gui_Gameplay_Menu);

%this.Ass_Unload();

}
