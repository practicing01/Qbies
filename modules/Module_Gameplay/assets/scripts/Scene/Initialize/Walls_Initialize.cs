function Module_Gameplay::Walls_Initialize(%this)
{

%Vector_2D_Star_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Star);

/*********************************************************************************************************/

//Bottom Edge

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Qbie);

%X_Border_Size=Window_Qbies.getCameraSize().X/%Vector_2D_Wall_Size.X;

%Y_Border_Size=Window_Qbies.getCameraSize().Y/%Vector_2D_Wall_Size.Y;

for (%z=0;%z<%this.Vector_2D_Map_Size.X;%z++)
{

for (%x=0;%x<%X_Border_Size;%x++)
{

%Vector_2D_Position=(%z*%X_Border_Size)+(%Vector_2D_Wall_Size.X*%x) SPC "0";

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Vector_2D_Star_Size;
Image="Module_Gameplay:Image_Star";
class="Class_Wall";
//CollisionCallback="true";
BodyType="static";
SceneLayer=16;

SceneGroup=30;//Dynamic world objects.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,25,26,30);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Qbies.add(%Sprite_Wall);

}

}

/*********************************************************************************************************/

//Top Edge

for (%z=0;%z<%this.Vector_2D_Map_Size.X;%z++)
{

for (%x=0;%x<%X_Border_Size;%x++)
{

%Vector_2D_Position=(%z*%X_Border_Size)+(%Vector_2D_Wall_Size.X*%x) SPC (9*%Y_Border_Size)+(%Vector_2D_Wall_Size.Y*(%Y_Border_Size-1));

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Vector_2D_Star_Size;
Image="Module_Gameplay:Image_Star";
class="Class_Wall";
//CollisionCallback="true";
BodyType="static";
SceneLayer=16;

SceneGroup=30;//Dynamic world objects.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,25,26,30);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Qbies.add(%Sprite_Wall);

}

}

/*********************************************************************************************************/

//Left Edge

for (%z=0;%z<%this.Vector_2D_Map_Size.Y;%z++)
{

for (%y=1;%y<%Y_Border_Size;%y++)//Start at one cus the x above used line 0
{

%Vector_2D_Position="0" SPC (%z*%Y_Border_Size)+(%Vector_2D_Wall_Size.Y*%y);

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Vector_2D_Star_Size;
Image="Module_Gameplay:Image_Star";
class="Class_Wall";
//CollisionCallback="true";
BodyType="static";
SceneLayer=16;

SceneGroup=30;//Dynamic world objects.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,25,26,30);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Qbies.add(%Sprite_Wall);

}

}

/*********************************************************************************************************/

//Right Edge

for (%z=0;%z<%this.Vector_2D_Map_Size.Y;%z++)
{

for (%y=1;%y<%Y_Border_Size;%y++)//Start at one cus the x above used line 0
{

%Vector_2D_Position=(9*%X_Border_Size)+(%Vector_2D_Wall_Size.X*(%X_Border_Size-1)) SPC (%z*%Y_Border_Size)+(%Vector_2D_Wall_Size.Y*%y);

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Vector_2D_Star_Size;
Image="Module_Gameplay:Image_Star";
class="Class_Wall";
//CollisionCallback="true";
BodyType="static";
SceneLayer=16;

SceneGroup=30;//Dynamic world objects.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0,25,26,30);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Qbies.add(%Sprite_Wall);

}

}

/*********************************************************************************************************/

//Randomized Walls



}
