function Module_Gui_Main_Menu::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_BG_Render.getAssetId());

//AssetDatabase.releaseAsset(%this.Ass_Audio_Torque_Wrench.getAssetId());

}
