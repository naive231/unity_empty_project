#!/bin/bash
Unity -quit \
  -nographics \
  -batchmode \
  -buildTarget Android \
  -customBuildTarget Android \
  -customBuildName ExampleProjectName \
  -executeMethod MyEditorScript.PerformBuild \
  -logFile build.log

echo $?
