function Class_Triangle::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Qbie")
{

%Colliding_Object.Qbie_Detach(%Colliding_Object);

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.ImageFont_Score.Text="Collisions:" SPC %this.Module_ID_Parent.Int_Score SPC "Elapsed Time:" SPC %this.Module_ID_Parent.ImageFont_Score.Int_Elapsed_Time;

}

}
