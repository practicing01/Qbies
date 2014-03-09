function Module_Gameplay::Triangles_Initialize(%this)
{

%Float_Map_Size_Quarter=(%this.Vector_2D_Map_Size.X*%this.Vector_2D_Map_Size.Y)/4;

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Triangle);

%X_Border_Size=Window_Qbies.getCameraSize().X/%Vector_2D_Wall_Size.X;

%Y_Border_Size=Window_Qbies.getCameraSize().Y/%Vector_2D_Wall_Size.Y;

%Vector_2D_Map_Size=(%this.Vector_2D_Map_Size.X*%X_Border_Size)+%X_Border_Size
SPC (%this.Vector_2D_Map_Size.Y*%Y_Border_Size)+%Y_Border_Size;

%Sprite_Qbie=0;

for (%x=0;%x<%Float_Map_Size_Quarter;%x++)
{

%Sprite_Triangle=new Sprite()
{

Position=getRandom(0+%Vector_2D_Wall_Size.X,%Vector_2D_Map_Size.X-%Vector_2D_Wall_Size.X) SPC getRandom(0+%Vector_2D_Wall_Size.Y,%Vector_2D_Map_Size.Y-%Vector_2D_Wall_Size.Y);
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Triangle);
Image="Module_Gameplay:Image_Triangle";
class="Class_Triangle";
BodyType="static";
CollisionCallback="true";
SceneLayer=16;

BlendColor="1.0 0.0 0.5 1.0";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

};

%Sprite_Triangle.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Sprite_Triangle.createPolygonBoxCollisionShape(%Sprite_Triangle.Size);

Scene_Qbies.add(%Sprite_Triangle);

}

}
