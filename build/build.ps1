Framework "4.0"

Properties {
    $build_dir = split-path $psake.build_script_file
    $project_dir = "$build_dir\.."

    $solution_file = "$project_dir\Coderoom.sln"
    $build_configuration = "Release"
}

task default -depends compile

FormatTaskName {
	param($taskName)
    write-host
	write-host (("-"*30) + "[ " + $taskName.ToUpper() + " ]" + ("-"*30)) -fore Green
    write-host
}

Task compile { 
    msbuild $solution_file /m /property:Configuration=$build_configuration /nologo
}