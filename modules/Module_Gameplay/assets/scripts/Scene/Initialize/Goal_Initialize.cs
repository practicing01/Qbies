function Module_Gameplay::Goal_Initialize(%this)
{

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Goal);

%X_Border_Size=Window_Qbies.getCameraSize().X/%Vector_2D_Wall_Size.X;

%Y_Border_Size=Window_Qbies.getCameraSize().Y/%Vector_2D_Wall_Size.Y;

%Vector_2D_Map_Size=(%this.Vector_2D_Map_Size.X*%X_Border_Size)+%X_Border_Size
SPC (%this.Vector_2D_Map_Size.Y*%Y_Border_Size)+%Y_Border_Size;

%Sprite_Goal=new Sprite()
{

Position=(%Vector_2D_Map_Size.X/2)+(%Vector_2D_Wall_Size.X/2) SPC (%Vector_2D_Map_Size.Y/2)+(%Vector_2D_Wall_Size.Y/2);
Size=%Vector_2D_Wall_Size;
Image="Module_Gameplay:Image_Goal";
class="Class_Goal";
BodyType="static";
CollisionCallback="true";
SceneLayer=16;
BlendColor="1.0 0.5 0.0 1.0";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

};

%Sprite_Goal.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Sprite_Goal.createPolygonBoxCollisionShape(%Sprite_Goal.Size);

%Sprite_Goal.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

Scene_Qbies.add(%Sprite_Goal);

}
