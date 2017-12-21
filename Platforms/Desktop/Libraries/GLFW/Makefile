VERSION = 3.2.1
VERSION_MAJOR = 3
OPTS = -DBUILD_SHARED_LIBS=ON
LINUX_CC = x86_64-linux-gnu-gcc
MAC_CC = x86_64-apple-darwin15-gcc
WINDOWS_CC = x86_64-w64-mingw32-gcc
OUTDIR = bin

.PHONY: all
all: $(OUTDIR)/libglfw.so.$(VERSION_MAJOR) $(OUTDIR)/libglfw.$(VERSION_MAJOR).dylib $(OUTDIR)/glfw$(VERSION_MAJOR).dll

.PHONY: clean
clean:
	rm -rf $(OUTDIR)/libglfw.so.$(VERSION_MAJOR) $(OUTDIR)/libglfw.$(VERSION_MAJOR).dylib $(OUTDIR)/glfw$(VERSION_MAJOR).dll \
		glfw-$(VERSION)-linux glfw-$(VERSION)-mac glfw-$(VERSION)-windows glfw-$(VERSION) glfw-$(VERSION).zip

glfw-$(VERSION).zip:
	wget "https://github.com/glfw/glfw/releases/download/$(VERSION)/glfw-$(VERSION).zip"
	touch "$@"

glfw-$(VERSION)/CMakeLists.txt: glfw-$(VERSION).zip
	unzip "$<"
	touch "$@"

glfw-$(VERSION)-linux/Makefile: glfw-$(VERSION)/CMakeLists.txt
	mkdir -p "glfw-$(VERSION)-linux"
	cd "glfw-$(VERSION)-linux" && cmake $(OPTS) -DCMAKE_SYSTEM_NAME=Linux -DCMAKE_C_COMPILER=$(LINUX_CC) "../glfw-$(VERSION)" || \
		echo -e '.PHONY: glfw\nglfw:\n\techo "Skipping Linux build." >&2' > Makefile

$(OUTDIR)/libglfw.so.$(VERSION_MAJOR): glfw-$(VERSION)-linux/Makefile
	mkdir -p "$(OUTDIR)"
	$(MAKE) -C "glfw-$(VERSION)-linux" glfw; cp --copy-contents "glfw-$(VERSION)-linux/src/libglfw.so.$(VERSION_MAJOR)" "$@" || true

glfw-$(VERSION)-mac/Makefile: glfw-$(VERSION)/CMakeLists.txt
	mkdir -p "glfw-$(VERSION)-mac"
	cd "glfw-$(VERSION)-mac" && cmake $(OPTS) -DCMAKE_SYSTEM_NAME=Darwin -DCMAKE_C_COMPILER=$(MAC_CC) "../glfw-$(VERSION)" || \
		echo -e '.PHONY: glfw\nglfw:\n\techo "Skipping Mac build." >&2' > Makefile

$(OUTDIR)/libglfw.$(VERSION_MAJOR).dylib: glfw-$(VERSION)-mac/Makefile
	mkdir -p "$(OUTDIR)"
	$(MAKE) -C "glfw-$(VERSION)-mac" glfw; cp --copy-contents "glfw-$(VERSION)-mac/src/libglfw.$(VERSION_MAJOR).dylib" "$@" || true

glfw-$(VERSION)-windows/Makefile: glfw-$(VERSION)/CMakeLists.txt
	mkdir -p "glfw-$(VERSION)-windows"
	cd "glfw-$(VERSION)-windows" && cmake $(OPTS) -DCMAKE_SYSTEM_NAME=Windows -DCMAKE_C_COMPILER=$(WINDOWS_CC) "../glfw-$(VERSION)" || \
		echo -e '.PHONY: glfw\nglfw:\n\techo "Skipping Windows build." >&2' > Makefile

$(OUTDIR)/glfw$(VERSION_MAJOR).dll: glfw-$(VERSION)-windows/Makefile
	mkdir -p "$(OUTDIR)"
	$(MAKE) -C "glfw-$(VERSION)-windows" glfw; cp --copy-contents "glfw-$(VERSION)-windows/src/glfw$(VERSION_MAJOR).dll" "$@" || true
