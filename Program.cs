using LevelUpRaylib;
using Raylib_cs;
using static Raylib_cs.Raylib;

InitWindow(1000, 1000, "Hello World");

SetTargetFPS(1);

Drawing main = new Drawing();
main.Init();

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(Color.WHITE);
    main.Text();
    main.Render();

    EndDrawing();
}

CloseWindow();

