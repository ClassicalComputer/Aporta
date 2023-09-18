#!/bin/bash

mkdir -p "$1/package/arm64/DEBIAN"
mkdir -p "$1/package/arm64/usr/local/bin/Aporta"
cp "$1/setup/Linux/control-arm64" "$1/package/arm64/DEBIAN/control"

cp -r "$1/src/Aporta/bin/Release/net7.0/linux-arm64/publish/*" "$1/package/arm64/usr/local/bin/Aporta"

dpkg-deb --build "$1/package/arm64" "$2/Aporta.linux-arm64.deb"