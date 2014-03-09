function Module_Gameplay::Score_Time_Update(%this,%ImageFont_Score)
{

if (!isObject(%ImageFont_Score))
{

return;

}

%ImageFont_Score.Int_Elapsed_Time++;

%ImageFont_Score.Text="Collisions:" SPC %this.Int_Score SPC "Elapsed Time:" SPC %ImageFont_Score.Int_Elapsed_Time;

%ImageFont_Score.Schedule_Time_Update=schedule(1000,0,"Module_Gameplay::Score_Time_Update",%this,%ImageFont_Score);

}

function Module_Gameplay::Score_Initialize(%this)
{

%Vector_2D_Wall_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Goal);

%X_Border_Size=Window_Qbies.getCameraSize().X/%Vector_2D_Wall_Size.X;

%Y_Border_Size=Window_Qbies.getCameraSize().Y/%Vector_2D_Wall_Size.Y;

%Vector_2D_Map_Size=(%this.Vector_2D_Map_Size.X*%X_Border_Size)+%X_Border_Size
SPC (%this.Vector_2D_Map_Size.Y*%Y_Border_Size)+%Y_Border_Size;

%this.Int_Score=0;

%this.ImageFont_Score=new ImageFont();

%this.ImageFont_Score.class="Class_ImageFont_Score";

%this.ImageFont_Score.Image="Qbies:Font";

%this.ImageFont_Score.FontSize="2 2";

%this.ImageFont_Score.TextAlignment="Center";

%this.ImageFont_Score.Int_Elapsed_Time=0;

%this.ImageFont_Score.Text="Collisions: 0" SPC "Elapsed Time:" SPC %this.ImageFont_Score.Int_Elapsed_Time;

%this.ImageFont_Score.BodyType="dynamic";

%this.ImageFont_Score.Collision_Shape_Index=%this.ImageFont_Score.createPolygonBoxCollisionShape(%this.ImageFont_Score.FontSize);

%this.ImageFont_Score.SceneGroup=1;

%this.ImageFont_Score.setCollisionGroups(1);//We'll use 1 for objects that should be sensors but can't because of crash bugs.

//%this.ImageFont_Score.setCollisionShapeIsSensor(%this.ImageFont_Score.Collision_Shape_Index,true);//Crash

Scene_Qbies.add(%this.ImageFont_Score);

%Vector_2D_Camera_Size=Window_Qbies.getCameraSize();

%this.ImageFont_Score.Position=(%Vector_2D_Map_Size.X/2)+(%Vector_2D_Wall_Size.X/2) SPC (%Vector_2D_Map_Size.Y/2)+(%Vector_2D_Wall_Size.Y/2);//%this.Sprite_Qbie_Player.Position;

//%this.ImageFont_Score.Position.X+=%Vector_2D_Camera_Size.X/2;

%this.ImageFont_Score.Position.Y+=%Vector_2D_Camera_Size.Y/2;

%this.ImageFont_Score.Position.Y-=%this.ImageFont_Score.FontSize.Y/2;

//%this.ImageFont_Score.Joint_ID_Weld=Scene_Qbies.createWeldJoint(%this.ImageFont_Score,%this.Sprite_Qbie_Player,
//%this.ImageFont_Score.getLocalVector(%this.Sprite_Qbie_Player.Position),%this.Sprite_Qbie_Player.getLocalVector(%this.ImageFont_Score.Position),0,1,false);

%this.ImageFont_Score.Schedule_Time_Update=schedule(1000,0,"Module_Gameplay::Score_Time_Update",%this,%this.ImageFont_Score);

/*%this.Gui_Text_Score=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text="Collisions: 0"; 
Extent="100 100";
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";
};

Gui_Gameplay_Menu.addGuiControl(%this.Gui_Text_Score);
*/
//%this.ImageFont_Score.mount(%this.Sprite_Qbie_Player,%Vector_2D_Camera_Size.X/2 SPC %Vector_2D_Camera_Size.Y/2,0,true,mDegToRad(0));

}

function Class_ImageFont_Score::onRemove(%this)
{

//Scene_Qbies.deleteJoint(%this.Joint_ID_Weld);

//%this.Joint_ID_Weld=-1;

//%this.dismount();

}
