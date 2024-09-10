#!/bin/bash
Unity -quit \
  -nographics \
  -batchmode \
  -buildTarget Android \
  -customBuildTarget Android \
  -customBuildName ExampleProjectName \
  -customBuildPath ./Builds/Android/ \
  -logFile build.log

