function validateForm() 
{
		
		var name = document.forms['form1'][0].value;
		if (name==null ||name=="")
		{
			alert("The Name field cannot be left blank.");
			return false;
		}
		
		var surname = document.forms['form1'][1].value;
		if (surname==null || surname=="")
		{
			alert("The Surname field cannot be left blank.");
			return false;
		}
		
		
		var email = document.forms['form1'][4].value;
		if (email==null ||email=="")
		{
			alert("The Email field cannot be left blank.");
			return false;
		}
		
		var phone = document.forms['form1'][4].value;
		if (phone==null ||phone=="")
		{
			alert("The Phone field cannot be left blank.");
			return false;
		}

		var comment = document.forms['form1'][4].value;
		if (comment==null ||comment=="")
		{
			alert("The Comment field cannot be left blank.");
			return false;
		}
		

		else
		{
			alert("Form submission completed successfully.");
			return true;
		}
}


	