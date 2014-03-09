function Module_Gameplay::Star_Initialize(%this)
{

%Float_Map_Size_Half=(%this.Vector_2D_Map_Size.X*%this.Vector_2D_Map_Size.Y)/2;

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Qbie);

%X_Border_Size=Window_Qbies.getCameraSize().X/%Vector_2D_Wall_Size.X;

%Y_Border_Size=Window_Qbies.getCameraSize().Y/%Vector_2D_Wall_Size.Y;

%Vector_2D_Map_Size=(%this.Vector_2D_Map_Size.X*%X_Border_Size)+%X_Border_Size
SPC (%this.Vector_2D_Map_Size.Y*%Y_Border_Size)+%Y_Border_Size;

%Vector_2D_Star_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Star);

for (%x=0;%x<%Float_Map_Size_Half;%x++)
{

%Sprite_Star=new Sprite()
{

Position=getRandom(0+%Vector_2D_Wall_Size.X,%Vector_2D_Map_Size.X-%Vector_2D_Wall_Size.X) SPC getRandom(0+%Vector_2D_Wall_Size.Y,%Vector_2D_Map_Size.Y-%Vector_2D_Wall_Size.Y);
Size=%Vector_2D_Star_Size;
Image="Module_Gameplay:Image_Star";
class="Class_Star";
BodyType="dynamic";
SceneLayer=17;

AngularVelocity=getRandomF(0,30);

Module_ID_Parent=%this;

};

Scene_Qbies.add(%Sprite_Star);

}

}
