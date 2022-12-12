using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;

namespace EmprendeFacil2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;
        EditText editTextNombre;
        EditText editTextDireccion;
        EditText editTextCiudad;
        EditText editTextDocumento;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);
            editTextNombre = FindViewById<EditText>(Resource.Id.editTextNombre);
            editTextDireccion = FindViewById<EditText>(Resource.Id.editTextDireccion);
            editTextCiudad = FindViewById<EditText>(Resource.Id.editTextCiudad);
            editTextDocumento = FindViewById<EditText>(Resource.Id.editTextDocumento);


            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    textMessage.Visibility = ViewStates.Visible;
                    textMessage.SetText(Resource.String.title_bienvenido);
                    editTextNombre.Visibility = ViewStates.Invisible;
                    editTextDireccion.Visibility = ViewStates.Invisible;
                    editTextDocumento.Visibility = ViewStates.Invisible;
                    editTextCiudad.Visibility = ViewStates.Invisible;
                    return true;
                case Resource.Id.navigation_dashboard:
                    textMessage.Visibility = ViewStates.Visible;
                    textMessage.SetText(Resource.String.title_dashboard);
                    editTextNombre.Visibility = ViewStates.Invisible;
                    editTextDireccion.Visibility = ViewStates.Invisible;
                    editTextDocumento.Visibility = ViewStates.Invisible;
                    editTextCiudad.Visibility = ViewStates.Invisible;
                    return true;
                case Resource.Id.navigation_notifications:
                    textMessage.Visibility = ViewStates.Visible;
                    textMessage.SetText(Resource.String.title_notifications);
                    editTextNombre.Visibility = ViewStates.Invisible;
                    editTextDireccion.Visibility = ViewStates.Invisible;
                    editTextDocumento.Visibility = ViewStates.Invisible;
                    editTextCiudad.Visibility = ViewStates.Invisible;
                    return true;
                case Resource.Id.navigation_galeria:
                    textMessage.Visibility = ViewStates.Visible;
                    textMessage.SetText(Resource.String.title_galeria);
                    editTextNombre.Visibility = ViewStates.Invisible;
                    editTextDireccion.Visibility = ViewStates.Invisible;
                    editTextDocumento.Visibility = ViewStates.Invisible;
                    editTextCiudad.Visibility = ViewStates.Invisible;
                    return true;
                case Resource.Id.navigation_registro:
                    textMessage.SetText(Resource.String.title_registro);
                    textMessage.Visibility = ViewStates.Invisible;
                    editTextNombre.Visibility = ViewStates.Visible;
                    editTextDireccion.Visibility = ViewStates.Visible;
                    editTextDocumento.Visibility = ViewStates.Visible;
                    editTextCiudad.Visibility = ViewStates.Visible;
                    return true;
            }

            return false;
        }
    }
}

