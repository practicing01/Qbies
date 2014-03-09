function Module_Gameplay::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Qbie.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Triangle.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Goal.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Star.getAssetId());

//AssetDatabase.releaseAsset(%this.Ass_Audio_Torque_Wrench.getAssetId());

}
