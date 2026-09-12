from pathlib import Path
from PIL import Image
import struct
import sys

SCRIPT_DIR = Path(__file__).resolve().parent
REPO_ROOT = SCRIPT_DIR.parent

SOURCE_IMAGE = SCRIPT_DIR / "A_Frutiger_Aero_themed_test_tube_mostly_opaqueclear_with_blu.jpg"

TARGET_ICO_FILES = [
    REPO_ROOT / "Installer" / "bluebox.ico",
]

ICO_SIZES = [16, 32, 48, 64, 90, 128, 256]


def load_and_crop_source():
    img = Image.open(SOURCE_IMAGE).convert("RGBA")
    w, h = img.size
    min_dim = min(w, h)
    left = (w - min_dim) // 2
    top = (h - min_dim) // 2
    img_square = img.crop((left, top, left + min_dim, top + min_dim))
    print(f"Source JPG: {w}x{h}")
    print(f"Cropped square: {img_square.size}")
    return img_square


def create_ico_images(img_square):
    images = []
    for size in ICO_SIZES:
        img_resized = img_square.resize((size, size), Image.LANCZOS)
        images.append(img_resized)
        print(f"  Prepared {size}x{size}")
    return images


def save_ico(images, output_path):
    master = images[-1]
    master.save(output_path, format="ICO", sizes=[(s, s) for s in ICO_SIZES])
    print(f"Saved ICO to {output_path} ({output_path.stat().st_size} bytes)")


def verify_ico(ico_path):
    with open(ico_path, "rb") as f:
        data = f.read()
    reserved = struct.unpack("<H", data[0:2])[0]
    ico_type = struct.unpack("<H", data[2:4])[0]
    count = struct.unpack("<H", data[4:6])[0]
    print(f"  Reserved: {reserved}, Type: {ico_type}, Images: {count}")
    offset = 6
    for i in range(count):
        width = data[offset]
        height = data[offset + 1]
        colors = data[offset + 2]
        planes = struct.unpack("<H", data[offset + 4 : offset + 6])[0]
        bit_count = struct.unpack("<H", data[offset + 6 : offset + 8])[0]
        size_val = struct.unpack("<I", data[offset + 8 : offset + 12])[0]
        offset_val = struct.unpack("<I", data[offset + 12 : offset + 16])[0]
        w = width if width != 0 else 256
        h = height if height != 0 else 256
        print(f"  Image {i}: {w}x{h}, colors={colors}, bpp={bit_count}, size={size_val}, offset={offset_val}")
        offset += 16


def main():
    print("Regenerating icon files from source JPG...")
    print(f"Source: {SOURCE_IMAGE}")
    print()

    if not SOURCE_IMAGE.exists():
        print(f"ERROR: Source JPG not found at: {SOURCE_IMAGE}")
        print(f"Please place 'A_Frutiger_Aero_themed_test_tube_mostly_opaqueclear_with_blue_a.png' in the same directory as this script.")
        sys.exit(1)

    for target in TARGET_ICO_FILES:
        target.parent.mkdir(parents=True, exist_ok=True)

    img_square = load_and_crop_source()
    images = create_ico_images(img_square)

    for target in TARGET_ICO_FILES:
        save_ico(images, target)
        print()
        verify_ico(target)
        print()

    print("All icon files regenerated successfully.")


if __name__ == "__main__":
    main()
