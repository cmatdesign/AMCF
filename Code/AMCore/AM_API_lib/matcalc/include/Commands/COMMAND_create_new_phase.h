#pragma once
#include "COMMAND_abstract.h"
#include "COMMAND_exception.h"
#include "../../../../AMLib/include/Database_implementations/Data_stuctures/DBS_All_Structures_Header.h"
#include "../../../../AMLib/interfaces/IAM_Communication.h"

class COMMAND_create_new_phase : public COMMAND_abstract
{
public:
	
	COMMAND_create_new_phase(AMFramework::Interfaces::IAM_Communication* mccComm, AM_Config* configuration, std::string phaseName, std::string parentPhase,
							 std::string phaseType, std::string other ) :
		COMMAND_abstract(mccComm, configuration)
	{

		_scriptContent = "create-new-phase parent-phase=" + parentPhase + " " + phaseType + " " + phaseName + "" + other + "\n";
		_command = _scriptContent;
	}

	virtual std::string DoAction() override
	{
		return send_command(_scriptContent);
	}

private:
	std::string _command{ "" };

};