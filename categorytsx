import React, { useEffect } from 'react';
import { useHistory, useParams } from 'react-router-dom';
import CustomInput from '../../components/common/customInput';
import SearchField from '../../components/common/searchField';
import NumberSpinner from '../../components/common/numberSpinner';
import Layout from '../../components/layout/layout';
import { makeStyles, Theme, useTheme } from '@material-ui/core/styles';
import {
  Grid,
  Fab,
  Box,
  Typography,
  IconButton,
  Divider,
  AppBar,
  Tabs,
  Tab,
  useMediaQuery,
} from '@material-ui/core';
import ShoppingCartIcon from '@material-ui/icons/ShoppingCart';
import AddShoppingCartIcon from '@material-ui/icons/AddShoppingCart';
import AddIcon from '@material-ui/icons/Add';
import RemoveIcon from '@material-ui/icons/Remove';
import FavoriteIcon from '@material-ui/icons/Favorite';
import FavoriteBorderIcon from '@material-ui/icons/FavoriteBorder';

const styles = makeStyles((theme: Theme) => ({
  container: {
    backgroundColor: theme.palette.background.paper,
    // padding: theme.spacing(3),
    [theme.breakpoints.down('sm')]: {
      // padding: theme.spacing(0)
    },
  },
  gridContainer: {
    marginTop: theme.spacing(1),
  },
  itemContainer: {
    // maxWidth: 300,
    marginBottom: `-${theme.spacing(3)}px`,
    [theme.breakpoints.down('sm')]: {
      width: '100% !important',
      maxWidth: '100vw',
    },
  },
  itemImg: {
    position: 'relative',
    display: 'flex',
    '& img': {
      objectFit: 'cover',
      margin: '0 auto',
      width: 350,
      height: 250,
      [theme.breakpoints.down('sm')]: {
        width: 126,
        height: 90,
      },
    },
  },
  itemDescription: {
    marginBottom: theme.spacing(3),
    '& dt': {
      fontSize: '1.6rem',
      [theme.breakpoints.down('sm')]: {
        fontSize: '1.2rem',
      },
      [theme.breakpoints.down('xs')]: {
        fontSize: '1rem',
      },
    },
    '& dd': {
      marginLeft: 0,
      fontSize: '1.4rem',
      [theme.breakpoints.down('sm')]: {
        fontSize: '1rem',
      },
    },
    '& dt, & dd': {
      marginTop: theme.spacing(1),
      [theme.breakpoints.down('sm')]: {
        paddingLeft: theme.spacing(3),
        marginTop: 0,
      },
    },
  },
  quantityField: {
    // position: 'relative',
    // '& > div, & > button': {
    //   position: 'absolute'
    // },
    // '& > div': {
    //   right: theme.spacing(6)
    // },
    // '& > button': {
    //   right: 0
    // }
  },
  addCartButton: {
    // paddingTop: 0,
    // paddingBottom: 0
  },
  favoriteButton: {
    color: 'red',
    [theme.breakpoints.up('md')]: {
      display: 'none',
    },
  },
  favoriteButtonXl: {
    position: 'absolute',
    bottom: theme.spacing(1),
    right: theme.spacing(1),
    color: 'red',
    [theme.breakpoints.down('sm')]: {
      display: 'none',
    },
  },
  fabButton: {
    position: 'absolute',
    bottom: theme.spacing(4),
    right: theme.spacing(4),
  },
  readonlyTextBlock: {
    marginBottom: theme.spacing(2),
    '& label' : {
      fontSize: '.9rem'
    },
    '& p': {
      fontSize: '1.2rem'
    }
  },
  categoryContainer: {
    marginTop: 0,
  },
  categoryItem: {

  },
}));

type ItemType = {
  id: string;
  img: string;
  name: string;
  standard: string;
  inQuantity?: number;
};

const items: ItemType[] = [
  {
    id: '0000001',
    img: 'https://food-foto.jp/free/img/images_big/fd401554.jpg',
    name: 'フライドフィッシュ ポテトフライ',
    standard: 'C/T',
    inQuantity: 5,
  },
  {
    id: '0000001',
    img: 'https://food-foto.jp/free/img/images_big/fd401587.jpg',
    name: '北海道産じゃがいも畑栗カボチャコロッケ',
    standard: 'C/T',
    inQuantity: 3,
  },
  {
    id: '0000001',
    img: 'https://food-foto.jp/free/img/images_big/was0001-004.jpg',
    name: 'エビフライ 2L',
    standard: 'C/T',
    inQuantity: 2,
  },
  {
    id: '0000001',
    img: 'https://via.placeholder.com/350x250.png',
    name: 'タイトルタイトルタイトル',
    standard: 'CS',
    inQuantity: 2,
  },
  {
    id: '0000001',
    img: 'https://via.placeholder.com/350x250.png',
    name: 'タイトルタイトルタイトル',
    standard: 'CS',
    inQuantity: 2,
  },
  {
    id: '0000001',
    img: 'https://via.placeholder.com/350x250.png',
    name: 'タイトルタイトルタイトル',
    standard: 'CS',
    inQuantity: 2,
  },
];

type CategoryType = {
  id: string;
  name: string;
}

const categores = [
  { id: '001', name: '冷凍(冷食)' },
  { id: '002', name: 'フライ' },
  { id: '003', name: '菓子' },
  { id: '004', name: '焼き物' },
  { id: '005', name: '惣菜' },
  { id: '006', name: '刺身' },
  { id: '007', name: '焼き物' },
  { id: '008', name: '焼き物' },
  { id: '009', name: '焼き物' },
]

interface TabPanelProps {
  children?: React.ReactNode;
  dir?: string;
  index: any;
  value: any;
}

function TabPanel(props: TabPanelProps) {
  const { children, value, index, ...other } = props;

  return (
    <div
      role="tabpanel"
      hidden={value !== index}
      id={`full-width-tabpanel-${index}`}
      aria-labelledby={`full-width-tab-${index}`}
      {...other}
    >
      {value === index && <Box p={3}>{children}</Box>}
    </div>
  );
}

function a11yProps(index: any) {
  return {
    id: `full-width-tab-${index}`,
    'aria-controls': `full-width-tabpanel-${index}`,
  };
}

interface Props {}

const Order: React.FC<Props> = (props) => {
  const classes = styles();
  const history = useHistory();
  const theme = useTheme();
  const isDownMd = useMediaQuery(theme.breakpoints.down('md'));
  const isDownXs = useMediaQuery(theme.breakpoints.down('xs'));
  const [tabPageIndex, setTabPageIndex] = React.useState(0);

  const fabButtonClick = () => {
    return;
  };

  const handleChange = (event: React.ChangeEvent<{}>, newValue: number) => {
    setTabPageIndex(newValue);
  };

  return (
    <Layout pageTitle="新規発注" hideContainerPadding>
      <Box className={classes.container}>
        <AppBar position="static">
          <Tabs
            value={tabPageIndex}
            onChange={handleChange}
            variant="fullWidth"
            aria-label="full width tabs example"
          >
            <Tab label="通常" {...a11yProps(0)} />
            <Tab label="カスタム条件" {...a11yProps(1)} />
          </Tabs>
        </AppBar>
        <TabPanel value={tabPageIndex} index={1} dir={theme.direction}>
          <SearchField />

          <Grid
            container
            spacing={isDownMd ? 5 : 10}
            className={classes.gridContainer}
          >
            {items.map((item, index) => (
              <Grid
                item
                xs={12}
                md={6}
                lg={3}
                container
                key={index}
                className={classes.itemContainer}
              >
                {/* <Grid container> */}
                <Grid item xs={4} sm={3} md={12}>
                  <Box className={classes.itemImg}>
                    <img src={item.img} alt={item.name} />
                    <IconButton
                      onClick={() => {
                        return;
                      }}
                      centerRipple
                      className={classes.favoriteButtonXl}
                    >
                      {true ? <FavoriteIcon /> : <FavoriteBorderIcon />}
                    </IconButton>
                  </Box>
                </Grid>

                <Grid
                  item
                  container
                  xs={8}
                  sm={9}
                  md={12}
                  className={classes.itemDescription}
                >
                  <Grid item xs={12}>
                    <Typography component="dt">{item.name}</Typography>
                  </Grid>
                  <Grid item xs={12}>
                    <Typography component="dd">{`規格: ${item.standard}`}</Typography>
                  </Grid>
                  {/* <Grid item xs={4}>
                        <Typography component="dd">{`入数: ${item.inQuantity}`}</Typography>
                      </Grid> */}
                  <Grid item xs={8} className={classes.quantityField}>
                    <Box component="dd">
                      <NumberSpinner />
                      <IconButton
                        color="inherit"
                        onClick={() => {
                          return;
                        }}
                        className={classes.addCartButton}
                      >
                        <AddShoppingCartIcon />
                      </IconButton>
                    </Box>
                  </Grid>
                  <Grid item xs={4} container justify="flex-end">
                    <IconButton
                      onClick={() => {
                        return;
                      }}
                      centerRipple
                      className={classes.favoriteButton}
                    >
                      {true ? <FavoriteIcon /> : <FavoriteBorderIcon />}
                    </IconButton>
                  </Grid>

                  {/* <IconButton
                    color="inherit"
                    size="small"
                    onClick={() => {return;}}
                    className={classes.addCartButton}>
                    <AddIcon />
                  </IconButton>
                  <IconButton
                    color="inherit"
                    size="small"
                    onClick={() => {return;}}
                    className={classes.addCartButton}>
                    <RemoveIcon />
                  </IconButton> */}
                </Grid>

                <Grid item xs={12}>
                  <Divider />
                </Grid>
              </Grid>
            ))}
          </Grid>
        </TabPanel>
        <TabPanel value={tabPageIndex} index={0} dir={theme.direction}>

        <Box>
          {/* <Typography component="label">{`カテゴリ`}</Typography> */}
          <Typography component="p" variant="h5">{'カテゴリ'}</Typography>

          <Grid container spacing={5} className={classes.categoryContainer}>
            {categores.map((category) => (
              <Grid key={category.id} item xs={6} md={4} lg={3} className={classes.categoryItem}>
                <Typography component="p">{category.name}</Typography>
              </Grid>
            ))}
          </Grid>
        </Box>

        </TabPanel>
      </Box>

      <Fab
        aria-label="カート"
        className={classes.fabButton}
        color="secondary"
        onClick={fabButtonClick}
      >
        <ShoppingCartIcon />
      </Fab>
    </Layout>
  );
};

export default Order;
