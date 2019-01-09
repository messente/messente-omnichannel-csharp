#!/usr/bin/env bash
#
# Generated by: https://github.com/openapitools/openapi-generator.git
#

frameworkVersion=net45

# sdk must match installed framworks under PREFIX/lib/mono/[value]
sdk=4.5.2-api

# langversion refers to C# language features. see man mcs for details.
langversion=${sdk}
nuget_cmd=nuget

# Match against our known SDK possibilities
case "${sdk}" in
  4)
    langversion=4
    ;;
  4.5*)
    langversion=5
    ;;
  4.6*)
    langversion=6
    ;;
  4.7*)
    langversion=7 # ignoring 7.1 for now.
    ;;
  *)
    langversion=6
    ;;
esac

echo "[INFO] Target framework: ${frameworkVersion}"

if ! type nuget &>/dev/null; then
    echo "[INFO] Download nuget and packages"
    wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe;
    nuget_cmd="mono nuget.exe"
fi

mozroots --import --sync
${nuget_cmd} install src/com.Messente.Omnichannel/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.10.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.1.0/lib/net45/RestSharp.dll bin/RestSharp.dll;
cp packages/JsonSubTypes.1.2.0/lib/net45/JsonSubTypes.dll bin/JsonSubTypes.dll

echo "[INFO] Run 'mcs' to build bin/com.Messente.Omnichannel.dll"
mcs -langversion:${langversion} -sdk:${sdk} -r:bin/Newtonsoft.Json.dll,bin/JsonSubTypes.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/com.Messente.Omnichannel.dll \
-recurse:'src/com.Messente.Omnichannel/*.cs' \
-doc:bin/com.Messente.Omnichannel.xml \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/com.Messente.Omnichannel.dll was created successfully"
fi
