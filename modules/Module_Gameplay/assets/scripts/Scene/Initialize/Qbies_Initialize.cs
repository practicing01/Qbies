function Module_Gameplay::Qbies_Initialize(%this)
{

%Float_Map_Size_Quarter=(%this.Vector_2D_Map_Size.X*%this.Vector_2D_Map_Size.Y)/4;

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Qbie);

%X_Border_Size=Window_Qbies.getCameraSize().X/%Vector_2D_Wall_Size.X;

%Y_Border_Size=Window_Qbies.getCameraSize().Y/%Vector_2D_Wall_Size.Y;

%Vector_2D_Map_Size=(%this.Vector_2D_Map_Size.X*%X_Border_Size)+%X_Border_Size
SPC (%this.Vector_2D_Map_Size.Y*%Y_Border_Size)+%Y_Border_Size;

%Sprite_Qbie=0;

for (%x=0;%x<%Float_Map_Size_Quarter;%x++)
{

%Sprite_Qbie=new Sprite()
{

Position=getRandom(0+%Vector_2D_Wall_Size.X,%Vector_2D_Map_Size.X-%Vector_2D_Wall_Size.X) SPC getRandom(0+%Vector_2D_Wall_Size.Y,%Vector_2D_Map_Size.Y-%Vector_2D_Wall_Size.Y);
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Qbie);
Image="Module_Gameplay:Image_Qbie";
class="Class_Qbie";
CollisionCallback="true";
SceneLayer=16;

BlendColor="0.0 0.5 0.25 1.0";

FixedAngle=true;

DefaultDensity=%this.Float_Qbie_Density=0.1;

DefaultRestitution=%this.Float_Qbie_Restitution=0.5;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Script_Object_Input_Controller=0;

Joint_Target_ID=-1;

Collision_Shape_Index=-1;

Simset_Qbies_Connected=0;

Bool_Connected_To_Qbie_Player=false;

Bullet=true;

};

%Sprite_Qbie.Simset_Qbies_Connected=new SimSet();

%Sprite_Qbie.setCollisionGroups(0,25,26,30);

%Sprite_Qbie.Collision_Shape_Index=%Sprite_Qbie.createPolygonBoxCollisionShape(%Sprite_Qbie.Size);

Scene_Qbies.add(%Sprite_Qbie);

%this.Simset_Qbies.add(%Sprite_Qbie);

%this.Int_Qbie_Total++;

%Sprite_Qbie.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Qbie_Input_Controller";

Qbie_Parent=%Sprite_Qbie;

};

Window_Qbies.addInputListener(%Sprite_Qbie.Script_Object_Input_Controller);

}

/****************************************************************/

Window_Qbies.mount(%Sprite_Qbie);

%Sprite_Qbie.BlendColor="0.0 0.25 0.5 1.0";

%this.Sprite_Qbie_Player=%Sprite_Qbie;

%Sprite_Qbie.Bool_Connected_To_Qbie_Player=true;

%this.Simset_Qbies_Connected_To_Player.add(%Sprite_Qbie);

}
