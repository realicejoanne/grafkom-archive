#ifndef H_H_
#define H_H_

/**
 * Define
 */
#define SCREEN_TITLE         "Hello World! :D"
#define SCREEN_WIDTH         600
#define SCREEN_HEIGHT         600
#define SCREEN_POSITION_X     100
#define SCREEN_POSITION_Y     100

/**
 * Structure
 */
typedef struct s_grafkom
{
    int screenPositionX;
    int screenPositionY;

    double side;
    double hyp;
    double sideHalf;
    double sideToFind;
    double ratio;

    GLclampf bgRed;
    GLclampf bgGreen;
    GLclampf bgBlue;
    GLclampf bgAlpha;

    GLfloat    drawRed;
    GLfloat    drawGreen;
    GLfloat    drawBlue;

    GLfloat z;
    GLfloat x1;
    GLfloat x2;
    GLfloat x3;
    GLfloat y1;
    GLfloat y2;
    GLfloat y3;

} t_grafkom;

#endif /* H_H_ */