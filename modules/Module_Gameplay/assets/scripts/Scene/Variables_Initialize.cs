function Module_Gameplay::Variables_Initialize(%this)
{

%this.Joint_Target_Max_Force=100;

%this.Vector_2D_Map_Size="10 10";

%this.Joint_Distance_Frequency=3;

%this.Joint_Distance_Damping_Ratio=0;

%this.Float_Qbie_Density=0.1;

%this.Float_Qbie_Restitution=0.5;

%this.Sprite_Qbie_Player=0;

%this.Int_Qbie_Total=0;

%this.Simset_Qbies=new SimSet();

%this.Simset_Qbies_Connected_To_Player=new SimSet();

%this.Schedule_Win=0;

}
